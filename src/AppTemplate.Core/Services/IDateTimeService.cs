using System;

namespace AppTemplate.Core.Services
{
    public interface IDateTimeService
    {
        DateTime LocalNow { get; }
        DateTime UtcNow { get; }
    }
}
