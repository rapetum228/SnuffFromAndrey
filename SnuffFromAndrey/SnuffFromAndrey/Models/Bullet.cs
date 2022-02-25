﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SnuffFromAndrey.Models
{
    public class Bullet: Unit
    {
        private ShotDirection _shotDirection;
        private const int _velocity = 10;
        private BattleField _battleField;
        public Bullet(BattleField battleField)
        {
            _battleField = battleField;
            XOffset = _battleField.Hero.XOffset;
            YOffset = _battleField.Hero.YOffset;
            _shotDirection = _battleField.Hero.CurrentShotDirection;

            Face = new Image
            {
                Source = ImageSource.FromResource("SnuffFromAndrey.Images.Bullet.png"),
                WidthRequest = 15,
            };
            XConstraint = Constraint.RelativeToParent((parent) =>
            {
                return XOffset;  
            });
            YConstraint = Constraint.RelativeToParent((parent) =>
            {
                return YOffset;
            });
            
        }

        public bool FlyBullet()
        {
            SelectDirection();
            return SelfDestruction(CheckToKill());
        }

        private void SelectDirection()
        {
            switch (_shotDirection)
            {
                case ShotDirection.Up: 
                    YOffset -= _velocity;
                    BattleField.SetYConstraint(Face, Constraint.Constant(YOffset));
                    break;
                case ShotDirection.Left:
                    XOffset += _velocity;
                    BattleField.SetXConstraint(Face, Constraint.Constant(XOffset));
                    break;
                case ShotDirection.Right: 
                    XOffset -= _velocity;
                    BattleField.SetXConstraint(Face, Constraint.Constant(XOffset));
                    break;
                case ShotDirection.Down: 
                    YOffset += _velocity;
                    BattleField.SetYConstraint(Face, Constraint.Constant(YOffset));
                    break;
                default: 
                    break;
            }

        }

        private bool SelfDestruction(bool isKiled)
        {
            bool conditionEndFly = XOffset > _battleField.Width || XOffset < 0 || YOffset > _battleField.Height || YOffset < 0 || isKiled;
            if (conditionEndFly)
            {
                _battleField.RemoveBullet(this);
                return false;
            } 
            else
                return true;
        }

        private bool CheckToKill()
        {
            if (_battleField.Enemies.Count == 0)
            {
                _battleField.AddEnemies();
            }
            Enemy enemy = _battleField.Enemies.Find(e => e.XOffset < XOffset + 10 && e.YOffset < YOffset+10);
            if (enemy != null)
            {
                _battleField.RevomeEnemy(enemy);
                return true;
            }
            return false;    
        }
    }
}
