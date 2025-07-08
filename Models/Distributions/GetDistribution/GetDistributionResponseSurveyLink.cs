using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.GetDistribution
{
    public class GetDistributionResponseSurveyLink
    {
        public string surveyId { get; set; }
        public DateTime? expirationDate { get; set; }
        public string linkType { get; set; }
    }
}
