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
            _viewModel.Top += 30;
            _viewModel.MarginBorders = new Thickness(_viewModel.Left,
               _viewModel.Top, _viewModel.Right, _viewModel.Bottom);
        }
    }
}
