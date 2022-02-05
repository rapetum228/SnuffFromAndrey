using SnuffFromAndrey.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SnuffFromAndrey
{
    public class ViewModel : INotifyPropertyChanged
    {

        public ICommand ToMoveUp { get; set; }
        public ICommand ToMoveDown { get; set; }
        public ICommand ToMoveLeft { get; set; }
        public ICommand ToMoveRight { get; set; }

        public ViewModel()
        {
            ToMoveUp = new ToMoveUpCommand(this);
            ToMoveDown = new ToMoveDownCommand(this);
            ToMoveLeft = new ToMoveLeftCommand(this);
            ToMoveRight = new ToMoveRightCommand(this);
            XConstraint = Constraint.RelativeToParent((parent) =>
            {
                return 0;  // установка координаты X
            });
            YConstraint = Constraint.RelativeToParent((parent) =>
            {
                return 0;  // установка координаты Y
            });

        }

        private Thickness _marginBorders;
        public Thickness MarginBorders
        {
            get { return _marginBorders; }
            set
            {
                _marginBorders = value;
                OnPropertyChanged(nameof(MarginBorders));
            }
        }

        private Constraint _xConstraint;
        public Constraint XConstraint
        {
            get { return _xConstraint; }
            set
            {
                _xConstraint = value;
                OnPropertyChanged(nameof(XConstraint));
            }
        }

        private Constraint _YConstraint;
        public Constraint YConstraint
        {
            get { return _YConstraint; }
            set
            {
                _YConstraint = value;
                OnPropertyChanged(nameof(YConstraint));
            }
        }


        private int _xConstant;
        public int XConstant
        {
            get { return _xConstant; }
            set
            {
                _xConstant = value;
                OnPropertyChanged(nameof(XConstant));
            }
        }
        private int _yConstant;
        public int YConstant
        {
            get { return _yConstant; }
            set
            {
                _yConstant = value;
                OnPropertyChanged(nameof(YConstant));
            }
        }

        private int _top;
        public int Top
        {
            get { return _top; }
            set
            {
                _top = value;
                OnPropertyChanged(nameof(Top));
            }
        }
        private int _right;
        public int Right
        {
            get { return _right; }
            set
            {
                _right = value;
                OnPropertyChanged(nameof(Right));
            }
        }
        private int _left;
        public int Left
        {
            get { return _left; }
            set
            {
                _left = value;
                OnPropertyChanged(nameof(Left));
            }
        }
        private int _bottom;
        public int Bottom
        {
            get { return _bottom; }
            set
            {
                _bottom = value;
                OnPropertyChanged(nameof(Bottom));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
