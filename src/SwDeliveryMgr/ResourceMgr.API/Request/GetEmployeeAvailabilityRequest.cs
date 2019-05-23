using System;
using System.Collections.Generic;
using System.Text;

namespace ResourceMgr.API.Request
{
    public class GetEmployeeAvailabilityRequest
    {
        public TimeRange TimeFilter { get; set; }

        public int[] EmployeeIdFilter { get; set; }

        public string[] AvailabilityIdFilter { get; set; }

        public PagingArgs Paging { get; set; }
    }
}
