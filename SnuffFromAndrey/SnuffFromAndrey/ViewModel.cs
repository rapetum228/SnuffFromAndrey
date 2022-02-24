using SnuffFromAndrey.Commands;
using SnuffFromAndrey.Models;
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
        public enum ShotDirection
        {
            Up,
            Left,
            Right,
            Down
        }

        public ICommand ToMoveUp { get; set; }
        public ICommand ToMoveDown { get; set; }
        public ICommand ToMoveLeft { get; set; }
        public ICommand ToMoveRight { get; set; }

        public ViewModel(BattleField battleField)
        {
            ToMoveUp = new ToMoveUpCommand(this);
            ToMoveDown = new ToMoveDownCommand(this);
            ToMoveLeft = new ToMoveLeftCommand(this);
            ToMoveRight = new ToMoveRightCommand(this);
            BattleField = battleField;
            Hero = BattleField.Hero;

        }

        public Hero Hero { get; set; }
        public BattleField BattleField { get; private set; }
        

        private int _actualShotDirection;
        public int ActualShotDirection
        {
            get { return _actualShotDirection; }
            set
            {
                _actualShotDirection = value;
                OnPropertyChanged(nameof(ActualShotDirection));
            }
        }

        
        
        private int _top;
        public int Top
        {
            get { return _top; }
            set
            {
                _top = value;
            }
        }
        private int _right;
        public int Right
        {
            get { return _right; }
            set
            {
                _right = value;
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
