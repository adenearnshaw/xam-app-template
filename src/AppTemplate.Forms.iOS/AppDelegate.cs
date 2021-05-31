using Foundation;
using Shiny;

[assembly: ShinyApplication(
    ShinyStartupTypeName = "AppTemplate.Forms.Startup",
    XamarinFormsAppTypeName = "AppTemplate.Forms.App"
)]

namespace AppTemplate.Forms.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {   
    }
}
