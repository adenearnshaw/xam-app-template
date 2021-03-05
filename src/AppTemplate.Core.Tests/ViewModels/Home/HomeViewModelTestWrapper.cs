using AppTemplate.Core.Managers;
using AppTemplate.Core.Services;
using AppTemplate.Forms.ViewModels;
using Moq;

namespace AppTemplate.Core.Tests.ViewModels.Home
{
    public class HomeViewModelTestWrapper
    {

        public HomeViewModelTestWrapper()
        {
            WorldTimeManagerMock = new();
            AppInfoServiceMock = new();

            AppInfoServiceMock.SetupGet(s => s.AppVersion).Returns(TestAppVersion);
        }

        public HomeViewModel GetSubject()
        {
            return new HomeViewModel(AppInfoServiceMock.Object, WorldTimeManagerMock.Object);
        }


        public Mock<IWorldTimeManager> WorldTimeManagerMock { get; set; }
        public Mock<IAppInfoService> AppInfoServiceMock { get; set; }

        public string TestAppVersion => "1.1.1";

    }
}
