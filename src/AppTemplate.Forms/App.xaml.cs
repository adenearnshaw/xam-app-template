using AppTemplate.Core;
using Shiny;
using Xamarin.Forms;

namespace AppTemplate.Forms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }        
    }
}
