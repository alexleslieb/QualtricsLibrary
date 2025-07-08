using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.CreateDistribution
{
    public class CreateDistributionRequestBodyRecipients
    {
        public string contactId { get; set; }
        public string mailingListId { get; set; }
    }
}
