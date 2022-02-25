using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SnuffFromAndrey.Models
{
    public class Hero : Unit
    {
        public ShotDirection CurrentShotDirection { get; set; }
        private BattleField _battleField;
        public Hero(BattleField battleField)
        {
            _battleField = battleField;

            Face = new Image
            {
                Source = ImageSource.FromResource("SnuffFromAndrey.Images.Hero.PNG"),
                WidthRequest = 45,
            };
            XConstraint = Constraint.RelativeToParent((parent) =>
            {
                return XOffset;  // установка координаты X
            });
            YConstraint = Constraint.RelativeToParent((parent) =>
            {
                return YOffset;  // установка координаты Y
            });
        }

        public void MoveCharacterVertically(int offset)
        {
            YOffset += offset;
            if (_battleField.Height - 15 <= YOffset || YOffset <= -10)
            {
                YOffset -= offset;
                return;
            }

            YConstraint = Constraint.Constant(YOffset);
            BattleField.SetYConstraint(Face, YConstraint);
        }

        public void MoveCharacterHorizontally(int offset)
        {
            XOffset += offset;
            if (_battleField.Width - 15 <= XOffset || XOffset <= -10)
            {
                XOffset -= offset;
                return;
            }

            XConstraint = Constraint.Constant(XOffset);
            BattleField.SetXConstraint(Face, XConstraint);
        }
    }
}
