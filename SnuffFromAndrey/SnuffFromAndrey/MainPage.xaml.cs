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
            Top = 0;
            Bottom = 0;
            Left = 0;
            Right = 0;
        }

        private void ButtonDown_Clicked(object sender, EventArgs e)
        {
            Top += 30;
            MainHero.Margin = new Thickness(Left, Top, Right, Bottom);
        }

        private void ButtonLeft_Clicked(object sender, EventArgs e)
        {
            Right -= 30;
            MainHero.Margin = new Thickness(Left, Top, Right, Bottom);
        }

        private void ButtonRight_Clicked(object sender, EventArgs e)
        {
            Right += 30;
            MainHero.Margin = new Thickness(Left, Top, Right, Bottom);
        }

        private void ButtonUp_Clicked(object sender, EventArgs e)
        {
            Top -= 30;
            MainHero.Margin = new Thickness(Left, Top, Right, Bottom);
        }
    }
}
