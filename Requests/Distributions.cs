using Newtonsoft.Json;
using QualtricsClassLibrary.Interfaces;
using QualtricsMiddleware.Application.Models.Distributions.GetDistribution;
using QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.CreateDistribution;
using QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.CreateSMSDistribution;
using QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.GetDistribution;
using QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.ListDistributions;
using QualtricsWebAPI.QualtricsClassLibrary.Models.Distributions.ListSMSDistributions;
using QualtricsWebAPI.QualtricsClassLibrary.Routes;
using System.Collections.Specialized;

namespace QualtricsWebAPI.QualtricsClassLibrary.Requests
{
    public class Distributions : Request, IDistributions
    {
        public Distributions(string baseUrl, string authenticationToken): base(baseUrl, authenticationToken) { }

        public async Task<ListDistributionsResponseDto> ListDistributions(ListDistributionsRequest request)
        {
            NameValueCollection nameValueCollection = new NameValueCollection();
            nameValueCollection.Add("surveyId", request.SurveyID);
            (string response, string requestUrl) = await SendQualtricsGetRequestAsync(
                ApiRoutes.Distributions.GetDistributions,
                nameValueCollection
                );

            ListDistributionsResponseDto responseDto = JsonConvert.DeserializeObject<ListDistributionsResponseDto>(response);
            responseDto.RequestUrl = requestUrl;
            responseDto.Request = JsonConvert.SerializeObject(request);
            return responseDto;
        }

        public async Task<CreateDistributionResponseDto> CreateDistribution(CreateDistributionRequest request)
        {
            (string response, string requestUrl) = await SendQualtricsPostRequestAsync(
                ApiRoutes.Distributions.CreateDistribution,
                JsonConvert.SerializeObject(request.Body)
                );

            CreateDistributionResponseDto responseDto = JsonConvert.DeserializeObject<CreateDistributionResponseDto>(response);
            responseDto.RequestUrl = requestUrl;
            responseDto.Request = JsonConvert.SerializeObject(request);
            return responseDto;
        }

        public async Task<CreateSMSDistributionResponseDto> CreateSMSDistribution(CreateSMSDistributionRequest request)
        {
            (string response, string requestUrl) = await SendQualtricsPostRequestAsync(
                ApiRoutes.Distributions.CreateSMSDistribution,
                JsonConvert.SerializeObject(request.Body)
                );

            CreateSMSDistributionResponseDto responseDto = JsonConvert.DeserializeObject<CreateSMSDistributionResponseDto>(response);
            responseDto.RequestUrl = requestUrl;
            responseDto.Request = JsonConvert.SerializeObject(request);
            return responseDto;
        }

        public async Task<ListSMSDistributionsResponseDto> ListSMSDistributions(ListSMSDistributionsRequest request)
        {
            NameValueCollection nameValueCollection = new NameValueCollection();
            nameValueCollection.Add("surveyId", request.SurveyID);
            (string response, string requestUrl) = await SendQualtricsGetRequestAsync(
                ApiRoutes.Distributions.ListSMSDistributions,
                nameValueCollection
                );

            ListSMSDistributionsResponseDto responseDto = JsonConvert.DeserializeObject<ListSMSDistributionsResponseDto>(response);
            responseDto.RequestUrl = requestUrl;
            responseDto.Request = JsonConvert.SerializeObject(request);
            return responseDto;
        }

        public async Task<GetDistributionResponseDto> GetDistribution(GetDistributionRequest request)
        {
            NameValueCollection nameValueCollection = new NameValueCollection();
            nameValueCollection.Add("surveyId", request.SurveyID);
            (string response, string requestUrl) = await SendQualtricsGetRequestAsync(
                ApiRoutes.Distributions.GetDistribution.Replace("{distributionId}", request.DistributionID),
                nameValueCollection 
                );

            GetDistributionResponseDto responseDto = JsonConvert.DeserializeObject<GetDistributionResponseDto>(response);
            responseDto.RequestUrl = requestUrl;
            responseDto.Request = JsonConvert.SerializeObject(request);
            return responseDto;
        }
    }
}
