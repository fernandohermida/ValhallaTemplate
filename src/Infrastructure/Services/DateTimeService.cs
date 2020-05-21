using ValhallaTemplate.Application.Common.Interfaces;
using System;

namespace ValhallaTemplate.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
