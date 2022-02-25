using SnuffFromAndrey.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SnuffFromAndrey.Commands
{
    public class ShotCommand : CommandBase
    {
        private readonly ViewModel _viewModel;
        public ShotCommand(ViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        public override void Execute(object parameter)
        {
            Bullet bullet = new Bullet(_viewModel.BattleField);
            _viewModel.BattleField.AddBullet(bullet);
            Device.StartTimer(TimeSpan.FromSeconds(0.025), bullet.FlyBullet);
        }

        
    }
}
