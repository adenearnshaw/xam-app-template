using AppTemplate.Core;
using AppTemplate.Forms.ViewModels;
using Xamarin.Forms;

namespace AppTemplate.Forms.Views.Home
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            BindingContext = CoreServiceLocator.Get<HomeViewModel>();
        }
    }
}