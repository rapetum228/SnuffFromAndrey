using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SnuffFromAndrey
{
    public partial class MainPage : ContentPage
    {
        private ViewModel _viewModel;

        bool alive = true;
        public MainPage()
        {
            InitializeComponent();
            _viewModel = new ViewModel(BloodBattleField);
            BindingContext = _viewModel;
        }

        private void ButtonShot_Clicked(object sender, EventArgs e)
        {
            //_viewModel.Right = _viewModel.XConstant;
            //_viewModel.Top = _viewModel.YConstant;

            Device.StartTimer(TimeSpan.FromSeconds(0.001), FlyBullet);
        }

        private bool FlyBullet()
        {
            switch (_viewModel.ActualShotDirection)
            {
                case (int)ViewModel.ShotDirection.Down:
                    _viewModel.Top -= 1;
                    break;
                case (int)ViewModel.ShotDirection.Left:
                    _viewModel.Right += 1;
                    break;
                case (int)ViewModel.ShotDirection.Right:
                    _viewModel.Right -= 1;
                    break;
                case (int)ViewModel.ShotDirection.Up:
                    _viewModel.Top += 1;
                    break;
                default:
                    break;
            }
            //if (flexim.Children.Count > 1)
            //{
            //    flexim.Children.RemoveAt(1);
            //}
            
            //Image image = new Image();
            //image.Source = ImageSource.FromResource("SnuffFromAndrey.Images.Bullet.png");
            //flexim.Children.Add(image,
            //    Constraint.RelativeToParent((parent) =>
            //    {
            //        return _viewModel.Right;  // установка координаты X
            //    }),
            //    Constraint.RelativeToParent((parent) =>
            //    {
            //        return _viewModel.Top; // установка координаты Y
            //    }),
            //    Constraint.Constant(15), // установка ширины
            //    Constraint.Constant(15)  // установка высоты
            //);
            return alive;
        }
    }
}
