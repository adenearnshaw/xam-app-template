using AppTemplate.Core.Services;
using AsyncAwaitBestPractices;
using System;
using System.Threading.Tasks;
using System.Timers;

namespace AppTemplate.Core.Managers
{
    public class WorldTimeManager : IWorldTimeManager
    {
        private readonly IDateTimeService _dateTime;

        Timer timer;

        private WeakEventManager<string> _timeInFranceUpdatedEventManager = new();
        public event EventHandler<string>? TimeInFranceUpdated
        {
            add => _timeInFranceUpdatedEventManager.AddEventHandler(value);
            remove => _timeInFranceUpdatedEventManager.RemoveEventHandler(value);
        }

        public WorldTimeManager(IDateTimeService dateTimeService)
        {
            _dateTime = dateTimeService;
        }


        public Task TurnOnTimeInFranceAutoRefresh()
        {
            timer = new Timer();
            timer.Interval = 500;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            RaiseTimeInFranceUpdated();
            return Task.CompletedTask;
        }

        public Task TurnOffTimeInFranceAutoRefresh()
        {
            if (timer == null)
                return Task.CompletedTask;

            timer.Stop();
            timer.Elapsed -= Timer_Elapsed;
            timer = null;
            return Task.CompletedTask;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            RaiseTimeInFranceUpdated();
        }

        private void RaiseTimeInFranceUpdated()
        {
            _timeInFranceUpdatedEventManager?.RaiseEvent(this, _dateTime.LocalNow.AddHours(1).ToLongTimeString(), nameof(TimeInFranceUpdated));
        }
    }
}
