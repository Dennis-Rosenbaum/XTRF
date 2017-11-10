using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Xtrf.Api.JobsSmart.Data
{
    public class Jobs : List<Job>
    {
        public Job GetFirstStep() => this?.OrderBy(j => j.StepNumber).FirstOrDefault();
    }
}
