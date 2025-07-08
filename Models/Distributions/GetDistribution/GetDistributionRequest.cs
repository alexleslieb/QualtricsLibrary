
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.GetDistribution
{
    public class GetDistributionRequest
    {
        public string DistributionID { get; set; }
        public string SurveyID { get; set; }
    }
}
