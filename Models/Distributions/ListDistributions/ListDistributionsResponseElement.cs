using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.ListDistributions
{
    public class ListDistributionsResponseElement
    {
        public string id { get; set; }
        public string parentDistributionId { get; set; }
        public string ownerId { get; set; }
        public string organizationId { get; set; }
        public string requestStatus { get; set; }
        public string requestType { get; set; }
        public DateTime sendDate { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime modifiedDate { get; set; }
        public ListDistributionsResponseHeaders headers { get; set; }
        public ListDistributionsResponseRecipients recipients { get; set; }
        public ListDistributionsResponseMessage message { get; set; }
        public ListDistributionsResponseSurveyLink surveyLink { get; set; }
        public ListDistributionsResponseStats stats { get; set; }
    }
}
