using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SnuffFromAndrey.Commands
{
    public class ToMoveLeftCommand : CommandBase
    {
        private readonly ViewModel _viewModel;
        public ToMoveLeftCommand(ViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        public override void Execute(object parameter)
        {
            _viewModel.Hero.MoveCharacterHorizontally(30);
            _viewModel.Hero.CurrentShotDirection = Models.ShotDirection.Left;
        }
    }
}
