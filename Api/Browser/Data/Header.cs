using System.Collections.Generic;

namespace Xtrf.Api.Browser.Data
{
    public class Header
    {
        public Pagination pagination { get; set; }
        public List<Column> columns { get; set; }
        public HeaderLinks links { get; set; }
        public bool editLinkAvailable { get; set; }
        public bool displayLinkAvailable { get; set; }
    }
}
