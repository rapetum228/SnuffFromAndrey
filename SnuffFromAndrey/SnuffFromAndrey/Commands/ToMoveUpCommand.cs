using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SnuffFromAndrey.Commands
{
    public class ToMoveUpCommand : CommandBase
    {
        private readonly ViewModel _viewModel;
        public ToMoveUpCommand(ViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object parameter)
        {
            _viewModel.Hero.MoveCharacterVertically(-30);
            _viewModel.Hero.CurrentShotDirection = Models.ShotDirection.Up;
        }
    }

}
