using System;
using System.Collections.Generic;
using System.Text;

namespace ResourceMgr.API
{
    public class PagingArgs
    {
        public int Skip { get; set; }
        public int Take { get; set; }
        public bool QueryTotalCount { get; set; }
    }
}
