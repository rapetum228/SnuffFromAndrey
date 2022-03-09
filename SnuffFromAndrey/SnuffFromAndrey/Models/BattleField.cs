using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SnuffFromAndrey.Models
{
    public class BattleField: RelativeLayout
    {
        private static BattleField _battleField;
        public Hero Hero { get; private set; }
        public List<Enemy> Enemies { get; set; }
        public int NumberRound { get; set; }
        public BattleField()
        {
            HeightRequest = 540;
            WidthRequest = 430;
            Hero = new Hero(this);
            Children.AddUnit(Hero);
            Enemies = new List<Enemy>();
            AddEnemies();
        }

        public static BattleField GetInstance()
        {
            if(_battleField is null)
                _battleField = new BattleField();

            return _battleField;
        }

        public void AddBullet(Bullet bullet)
        {
            Children.AddUnit(bullet);
        }

        public void RemoveBullet(Bullet bullet)
        {
            Children.RemoveUnit(bullet);
        }
       
        public void RevomeEnemy(Enemy enemy)
        {
            Children.RemoveUnit(enemy);
            Enemies.Remove(enemy);
        }

        public void AddEnemies()
        {
            Enemies.Clear();
            NumberRound++;
            for (int i = 0; i < NumberRound; i++)
            {
                var enemy = new Enemy(this);
                Enemies.Add(enemy);
                Children.AddUnit(enemy);
            }
        }
    }
}
