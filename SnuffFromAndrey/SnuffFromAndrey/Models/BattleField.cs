using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SnuffFromAndrey.Models
{
    public class BattleField: RelativeLayout
    {
        public Hero Hero { get; private set; }
        public List<Enemy> Enemies { get; set; }

        public BattleField()
        {
            Hero = new Hero(this);
            Children.AddUnit(Hero);
            SetXConstraint(Hero.Face, Hero.XConstraint);
            Enemies = new List<Enemy>();
        }

        public void AddBullet(Bullet bullet)
        {
            Children.AddUnit(bullet);
        }

        public void RemoveBullet(Bullet bullet)
        {
            Children.RemoveUnit(bullet);
        }
       
        
    }
}
