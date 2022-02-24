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
            Hero = new Hero();
            Children.AddHero(Hero);
            SetXConstraint(Hero.Face, Hero.XConstraint);
            Enemies = new List<Enemy>();
        }

        public void MoveCharacterVertically(int offset, Character character)
        {

            character.YOffset += offset;
            character.YConstraint = Constraint.Constant(character.YOffset );
            SetYConstraint(character.Face, character.YConstraint);
        }

        public void MoveCharacterHorizontally(int offset, Character character)
        {
            character.XOffset += offset;
            character.XConstraint = Constraint.Constant(character.XOffset);
            SetXConstraint(character.Face, character.XConstraint);
        }
    }
}
