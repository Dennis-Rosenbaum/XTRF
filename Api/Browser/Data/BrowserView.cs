using System.Collections.Generic;
using System.Linq;

namespace Xtrf.Api.Browser.Data
{
    public class BrowserView
    {
        public Header header { get; set; }
        public Dictionary<string, SingleRow> rows { get; set; }
        //public Deferred deferred { get; set; }

        public SingleRow GetRow(int index)
        {
            var row = rows.Where(r => r.Key == index.ToString());
            if (row.Any())
                return row.First().Value;
            return null;
        }
    }
}
