using System;

namespace AppTemplate.Core.Services
{
    public class DateTimeService : IDateTimeService
    {

        public DateTime LocalNow => DateTime.Now;

        public DateTime UtcNow => DateTime.UtcNow;
    }
}
