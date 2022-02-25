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
        public ICommand ToMoveUp { get; set; }
        public ICommand ToMoveDown { get; set; }
        public ICommand ToMoveLeft { get; set; }
        public ICommand ToMoveRight { get; set; }
        public ICommand Shot { get; set; }

        public ViewModel(BattleField battleField)
        {
            ToMoveUp = new ToMoveUpCommand(this);
            ToMoveDown = new ToMoveDownCommand(this);
            ToMoveLeft = new ToMoveLeftCommand(this);
            ToMoveRight = new ToMoveRightCommand(this);
            Shot = new ShotCommand(this);
            BattleField = battleField;
            Hero = BattleField.Hero;

        }

        public Hero Hero { get; set; }
        public BattleField BattleField { get; private set; }
        
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
