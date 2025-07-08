using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.GetDistribution
{
    public class GetDistributionResponseResult
    {
        public string id { get; set; }
        public string parentDistributionId { get; set; }
        public string ownerId { get; set; }
        public string organizationId { get; set; }
        public string requestStatus { get; set; }
        public string requestType { get; set; }
        public DateTime? sendDate { get; set; }
        public DateTime? createdDate { get; set; }
        public DateTime? modifiedDate { get; set; }
        //custom headers
        public GetDistributionResponseHeaders headers { get; set; }
        public GetDistributionResponseRecipients recipients { get; set; }
        public GetDistributionResponseMessage message { get; set; }
        public GetDistributionResponseSurveyLink surveyLink { get; set; }
        //embedded data
        public GetDistributionResponseStats stats { get; set; }
    }
}
