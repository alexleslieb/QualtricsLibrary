using QualtricsMiddleware.Application.Models.Distributions.GetDistribution;
using QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.CreateDistribution;
using QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.CreateSMSDistribution;
using QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.GetDistribution;
using QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.ListDistributions;
using QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.ListSMSDistributions;

namespace QualtricsClassLibrary.Interfaces
{
    public interface IDistributions
    {
        public Task<ListDistributionsResponseDto> ListDistributions(ListDistributionsRequest request);
        public Task<CreateDistributionResponseDto> CreateDistribution(CreateDistributionRequest request);
        public Task<CreateSMSDistributionResponseDto> CreateSMSDistribution(CreateSMSDistributionRequest request);
        public Task<ListSMSDistributionsResponseDto> ListSMSDistributions(ListSMSDistributionsRequest request);
        public Task<GetDistributionResponseDto> GetDistribution(GetDistributionRequest request);
    }
}
