using AppTemplate.Core.Managers;
using AppTemplate.Core.Services;
using MvvmHelpers;
using MvvmHelpers.Commands;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppTemplate.Forms.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private readonly IAppInfoService _appInfoService;
        private readonly IWorldTimeManager _worldTimeManager;

        private string _currentTimeInFrance;
        public string CurrentTimeInFrance
        {
            get => _currentTimeInFrance;
            set => SetProperty(ref _currentTimeInFrance, value);
        }

        public string AppVersion => _appInfoService.AppVersion;

        public ICommand FetchLatestTimeCommand { get; }

        public HomeViewModel(IAppInfoService appInfoService,
                             IWorldTimeManager worldTimeManager)
        {
            _appInfoService = appInfoService;
            _worldTimeManager = worldTimeManager;

            // Don't need to worry about un-subscribing, as using the WeakEventManager
            _worldTimeManager.TimeInFranceUpdated += TimeInFranceUpdated;

            FetchLatestTimeCommand = new AsyncCommand(FetchLatestTime);
        }

        private void TimeInFranceUpdated(object sender, string eventArgs)
        {
            CurrentTimeInFrance = eventArgs;
        }

        private async Task FetchLatestTime()
        {
            if (string.IsNullOrEmpty(CurrentTimeInFrance))
            {
                await _worldTimeManager.TurnOnTimeInFranceAutoRefresh();
            }
            else
            {
                await _worldTimeManager.TurnOffTimeInFranceAutoRefresh();
                CurrentTimeInFrance = string.Empty;
            }

        }

    }
}