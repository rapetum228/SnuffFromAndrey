using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SnuffFromAndrey.Models
{
    public class Enemy : Unit
    {
        private BattleField _battleField;
        public Enemy(BattleField battleField)
        {
            _battleField = battleField;
            Random random = new Random();
            XOffset = random.Next(0, 400);
            YOffset = random.Next(0, 530);

            Face = new Image
            {
                Source = ImageSource.FromResource("SnuffFromAndrey.Images.DogEnemy.png"),
                WidthRequest = 45,
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
    }
}
