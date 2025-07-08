using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.ListDistributions
{
    public class ListDistributionsResponseResult
    {
        public List<ListDistributionsResponseElement> elements { get; set; }
        public string nextPage { get; set; }
    }
}
