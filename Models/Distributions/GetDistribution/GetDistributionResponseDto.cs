
using QualtricsWebAPI.QualtricsClassLibrary.Models.Common;
using QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.GetDistribution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsMiddleware.Application.Models.Distributions.GetDistribution
{
    public class GetDistributionResponseDto: ResponseDto
    {
        public GetDistributionResponseResult result { get; set; }
    }
}
