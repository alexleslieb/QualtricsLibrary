using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.GetDistribution
{
    public class GetDistributionResponseHeaders
    {
        public string fromEmail { get; set; }
        public string replyToEmail { get; set; }
        public string fromName { get; set; }
        public string subject { get; set; }
    }
}
