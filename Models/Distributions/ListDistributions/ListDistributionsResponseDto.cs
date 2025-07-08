using QualtricsWebAPI.QualtricsClassLibrary.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.ListDistributions
{
    public class ListDistributionsResponseDto: ResponseDto
    {
        public ListDistributionsResponseResult result { get; set; }
    }
}
