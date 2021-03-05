using System;
using Shiny;
using Android.App;
using Android.Runtime;


namespace AppTemplate.Forms.Droid
{
    [Application]
    public class MainApplication : Shiny.ShinyAndroidApplication<Startup>
    {
        public MainApplication(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
        {
        }
    }
}