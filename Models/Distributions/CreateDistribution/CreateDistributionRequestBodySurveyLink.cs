using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.CreateDistribution
{
    public class CreateDistributionRequestBodySurveyLink
    {
        public string surveyId { get; set; }
        public DateTime expirationDate { get; set; }
        public string type { get; set; }
    }
}
