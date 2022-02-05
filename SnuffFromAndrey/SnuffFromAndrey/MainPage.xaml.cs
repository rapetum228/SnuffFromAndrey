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
        Thickness margin;
        public int Top { get; set; }
        public int Bottom { get; set; }
        public int Left { get; set; }
        public int Right { get; set; }
        public MainPage()
        {
            InitializeComponent();
            _viewModel = new ViewModel();
            BindingContext = _viewModel;
        }

        private void ButtonShot_Clicked(object sender, EventArgs e)
        {
            int x = _viewModel.XConstant;
            int y = _viewModel.YConstant;
            Image image = new Image();
            image.Source = ImageSource.FromResource("SnuffFromAndrey.Images.Bullet.png");
            flexim.Children.Add(image,
                Constraint.RelativeToParent((parent) =>
                {
                    return x;  // установка координаты X
                }),
            Constraint.RelativeToParent((parent) =>
            {
                return y; // установка координаты Y
            }),
            Constraint.Constant(15), // установка ширины
            Constraint.Constant(15)  // установка высоты
        );
        }
    }
}
