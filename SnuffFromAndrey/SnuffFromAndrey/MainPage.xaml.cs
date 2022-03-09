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
        public MainPage()
        {
            InitializeComponent();
            _viewModel = new ViewModel(BloodBattleField);
            BindingContext = _viewModel;
        }

    }
}
