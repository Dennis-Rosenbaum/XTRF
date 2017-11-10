using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xtrf.Api.Browser.Data
{
    public class Column
    {
        public string type { get; set; }
        public string name { get; set; }
        public string header { get; set; }
        public bool sortable { get; set; }
        public bool deferred { get; set; }
        //public Links2 links { get; set; }
        public string internalHeader { get; set; }
        public string fullHeader { get; set; }
    }
}
