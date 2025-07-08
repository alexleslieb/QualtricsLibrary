using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.CreateSMSDistribution
{
    public class CreateSMSDistributionRequestRecipients
    {
        public string mailingListId { get; set; }
        public string contactId { get; set; }
    }
}
