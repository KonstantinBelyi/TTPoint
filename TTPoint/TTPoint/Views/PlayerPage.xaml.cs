using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTPoint.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TTPoint.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayerPage : ContentPage
    {
        public PlayerViewModel ViewModel { get; private set; }
        public PlayerPage(PlayerViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;
            BindingContext = ViewModel;
        }
    }
}