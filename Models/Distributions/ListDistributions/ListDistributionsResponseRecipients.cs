using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.ListDistributions
{
    public class ListDistributionsResponseRecipients
    {
        public string mailingListId { get; set; }
        public string contactId { get; set; }
        public string libraryId { get; set; }
        public string sampleId { get; set; }
    }
}
