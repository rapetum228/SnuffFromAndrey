using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SnuffFromAndrey.Models
{
    public class Enemy : Unit
    {
        private const int _velocity = 10;
        private ShotDirection _direction;
        public Enemy(BattleField battleField):base(battleField)
        {
            Random random = new Random();
            FaceSize = (int)(_battleField.HeightRequest * 0.08);
            XOffset = random.Next(0, (int)_battleField.WidthRequest);
            YOffset = random.Next(0, (int)_battleField.HeightRequest);

            Face = new Image
            {
                Source = ImageSource.FromResource("SnuffFromAndrey.Images.FunnySmileEnemy.png"),
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

            Device.StartTimer(TimeSpan.FromSeconds(0.025), this.Move);
        }

        public bool Move()
        {
            
        }
    }
}
