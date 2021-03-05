using AppTemplate.Core.Services;

namespace AppTemplate.Forms.Services
{
    public class AppInfoService : IAppInfoService
    {
        public string AppVersion => Xamarin.Essentials.AppInfo.VersionString;
    }
}
