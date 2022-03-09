using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SnuffFromAndrey.Models
{
    public class Bullet: Unit
    {
        private ShotDirection _shotDirection;
        private const int _velocity = 10;
       
        public Bullet(BattleField battleField) : base(battleField)
        {
            XOffset = _battleField.Hero.XOffset + GetAdditionalOffset();
            YOffset = _battleField.Hero.YOffset + GetAdditionalOffset();
            _shotDirection = _battleField.Hero.CurrentShotDirection;
            FaceSize = 15;

            Face = new Image
            {
                Source = ImageSource.FromResource("SnuffFromAndrey.Images.Bullet.png"),
                WidthRequest = FaceSize,
                HeightRequest = FaceSize
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
            double h = _battleField.Width;
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
           
            Enemy enemy = _battleField.Enemies.Find(e => Math.Abs(e.XOffset - XOffset) < 20 && Math.Abs(e.YOffset - YOffset) <  20);
            if (enemy != null)
            {
                if (_battleField.Enemies.Count == 0)
                {
                    _battleField.AddEnemies();
                }
                _battleField.RevomeEnemy(enemy);
                return true;
            }
            return false;    
        }

        private int GetAdditionalOffset()
        {
            int faceSize = _battleField.Hero.FaceSize;
            int offset = faceSize / 2;
            return offset;
        }
    }
}
