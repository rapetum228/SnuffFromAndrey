using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SnuffFromAndrey.Models
{
    public class Hero : Character
    {
        public Hero()
        {
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

       
    }
}
