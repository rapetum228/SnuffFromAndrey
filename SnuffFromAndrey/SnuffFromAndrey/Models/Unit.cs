using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace SnuffFromAndrey.Models
{
    public abstract class Unit
    {
        public Image Face { get; set; }
        public int XOffset { get; set; }
        public int YOffset { get; set; }
        public Constraint XConstraint { get; set; }
        public Constraint YConstraint { get; set; }


    }
}
