using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.CreateSMSDistribution
{
    public class CreateSMSDistributionRequestBody
    {
        public string surveyId { get; set; }
        public string method { get; set; }
        public DateTime sendDate { get; set; }
        public CreateSMSDistributionRequestRecipients recipients { get; set; }
        public string name { get; set; }
        public CreateSMSDistributionRequestMessage message { get; set; }
    }
}
