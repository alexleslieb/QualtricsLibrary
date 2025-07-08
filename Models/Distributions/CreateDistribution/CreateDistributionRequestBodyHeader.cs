using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.CreateDistribution
{
    public class CreateDistributionRequestBodyHeader
    {
        public string fromName { get; set; }
        public string replyToEmail { get; set; }
        public string fromEmail { get; set; }
        public string subject { get; set; }
    }
}
