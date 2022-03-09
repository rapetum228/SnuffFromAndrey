using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace SnuffFromAndrey.Models
{
    public abstract class Unit
    {
        protected BattleField _battleField;
        public Image Face { get; protected set; } 
        public int FaceSize { get; protected set; }
        public int XOffset { get; set; }
        public int YOffset { get; set; }
        public Constraint XConstraint { get; set; }
        public Constraint YConstraint { get; set; }
        

        public Unit(BattleField battleField)
        {
            _battleField = battleField;
        }


    }
}
