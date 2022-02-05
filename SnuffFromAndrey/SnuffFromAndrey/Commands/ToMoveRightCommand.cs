using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SnuffFromAndrey.Commands
{
    public class ToMoveRightCommand : CommandBase
    {
        private readonly ViewModel _viewModel;
        public ToMoveRightCommand(ViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        public override void Execute(object parameter)
        {
            _viewModel.XConstant -= 30;
            _viewModel.XConstraint = Constraint.Constant(_viewModel.XConstant);
        }
    }
}
