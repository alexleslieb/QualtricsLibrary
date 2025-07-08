using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.ListSMSDistributions
{
    public class ListSMSDistributionsResponseStats
    {
        public int sent { get; set; }
        public int started { get; set; }
        public int finished { get; set; }
        public int failed { get; set; }
        public int credits { get; set; }
        public int segments { get; set; }
    }
}
