using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.ListSMSDistributions
{
    public class ListSMSDistributionsResponseResult
    {
        public List<ListSMSDistributionsResponseElement> elements { get; set; }
        public string nextPage { get; set; }
    }
}
