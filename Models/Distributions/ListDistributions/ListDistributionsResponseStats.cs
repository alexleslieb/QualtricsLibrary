using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.ListDistributions
{
    public class ListDistributionsResponseStats
    {
        public int sent { get; set; }
        public int failed { get; set; }
        public int started { get; set; }
        public int bounced { get; set; }
        public int opened { get; set; }
        public int skipped { get; set; }
        public int finished { get; set; }
        public int complaints { get; set; }
        public int blocked { get; set; }
    }
}
