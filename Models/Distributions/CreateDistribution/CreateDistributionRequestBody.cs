using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.CreateDistribution
{
    public class CreateDistributionRequestBody
    {
        public CreateDistributionRequestBodyMessage message { get; set; }
        public CreateDistributionRequestBodyRecipients recipients { get; set; }
        public CreateDistributionRequestBodyHeader header { get; set; }
        public CreateDistributionRequestBodySurveyLink surveyLink { get; set; }
        public DateTime sendDate { get; set; }
    }
}
