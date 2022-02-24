using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SnuffFromAndrey.Commands
{
    public class ToMoveDownCommand : CommandBase
    {
        private readonly ViewModel _viewModel;
        public ToMoveDownCommand(ViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        public override void Execute(object parameter)
        {
            _viewModel.BattleField.MoveCharacterVertically(30, _viewModel.Hero);
        }
    }
}
