using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.ListSMSDistributions
{
    public class ListSMSDistributionsResponseMessage
    {
        public string messageType { get; set; }
        public string messageId { get; set; }
        public string libraryId { get; set; }
    }
}
