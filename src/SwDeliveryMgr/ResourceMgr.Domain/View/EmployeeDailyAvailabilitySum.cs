using System;
using System.Collections.Generic;
using System.Text;

namespace ResourceMgr.Domain.View
{
    using Model;

    public class EmployeeDailyAvailabilitySum
    {
        public Employee Employee { get; set; }
        public DateTime Date { get; set; }
        public Availability Availability { get; set; }
        public TimeSpan DurationSum { get; set; }
    }
}
