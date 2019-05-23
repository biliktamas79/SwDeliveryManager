using System;
using System.Collections.Generic;
using System.Text;

namespace ResourceMgr.API
{
    public class PagedResult<T>
    {
        public int Skip { get; set; }
        public int Take { get; set; }
        public bool HasMoreItems { get; set; }
        public int? TotalCount { get; set; }

        public T[] Items { get; set; }
    }
}
