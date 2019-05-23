using System;
using System.Collections.Generic;
using System.Text;

namespace ResourceMgr.Domain.Model
{
    public class Availability
    {
        /// <summary>
        /// Primary key of Availability, like "WFH" for WorkingFromHome, "WFO" for WorkingFromOffice, "H" for Holiday, ...
        /// </summary>
        public string Id { get; set; }

        public string Name { get; set; }

        public bool IsWorking { get; set; }
    }
}
