using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.ListSMSDistributions
{
    public class ListSMSDistributionsResponseElement
    {
        public string id { get; set; }
        public string name { get; set; }
        public string ownerId { get; set; }
        public string organizationId { get; set; }
        public string requestStatus { get; set; }
        public string requestType { get; set; }
        public DateTime sendDate { get; set; }
        public string surveyId { get; set; }
        public ListSMSDistributionsResponseRecipient recipients { get; set; }
        public ListSMSDistributionsResponseMessage message { get; set; }
        public ListSMSDistributionsResponseStats stats { get; set; }
        public DateTime surveyLinkExpirationDate { get; set; }
    }
}
