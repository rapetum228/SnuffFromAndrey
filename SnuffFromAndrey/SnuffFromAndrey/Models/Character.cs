using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace SnuffFromAndrey.Models
{
    public abstract class Character//: BaseViewModel
    {
        //private Constraint _xConstarit;
        //private Constraint _yConstarit;
        //private int _xOffset;
        //private int _yOffset;
        public Image Face { get; set; }

        public int XOffset { get; set; }//{ get { return _xOffset; } set { _xOffset = value; OnPropertyChanged(nameof(XOffset)); } }
        public int YOffset { get; set; }//{ get { return _yOffset; } set { _yOffset = value; OnPropertyChanged(nameof(YOffset)); } }

        public Constraint XConstraint
        {
            get; /*{ return _xConstarit; }*/
            set;
            //{
            //    _xConstarit = value;
            //    OnPropertyChanged(nameof(XConstraint));
            //}
        }

        public Constraint YConstraint
        {
            get; /*{ return _yConstarit; }*/
            set;
            //{
            //    _yConstarit = value;
            //    OnPropertyChanged(nameof(YConstraint));
            //}
        }

        
    }
}
