using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.ListDistributions
{
    public class ListDistributionsResponseMessage
    {
        public string libraryId { get; set; }
        public string messageId { get; set; }
        public string messageType { get; set; }
    }
}
