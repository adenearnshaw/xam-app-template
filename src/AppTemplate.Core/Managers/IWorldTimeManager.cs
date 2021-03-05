using System;
using System.Threading.Tasks;

namespace AppTemplate.Core.Managers
{
    public interface IWorldTimeManager
    {
        event EventHandler<string> TimeInFranceUpdated;
        Task TurnOnTimeInFranceAutoRefresh();
        Task TurnOffTimeInFranceAutoRefresh();
    }
}
