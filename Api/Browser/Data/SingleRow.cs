using System.Collections.Generic;

namespace Xtrf.Api.Browser.Data
{
    public class SingleRow
    {
        public int id { get; set; }
        public SingleRowLinks links { get; set; }
        public List<string> columns { get; set; }
    }
}
