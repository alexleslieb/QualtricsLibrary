using Newtonsoft.Json;
using QualtricsWebAPI.QualtricsClassLibrary.Models.Surveys.ListSurveys;
using QualtricsWebAPI.QualtricsClassLibrary.Models.Surveys.GetSurvey;
using QualtricsWebAPI.QualtricsClassLibrary.Routes;
using QualtricsClassLibrary.Interfaces;

namespace QualtricsWebAPI.QualtricsClassLibrary.Requests
{
    public class Surveys : Request, ISurveys
    {
        public Surveys(string baseUrl, string authenticationToken) : base(baseUrl, authenticationToken) { }

        public async Task<GetSurveyResponseDto> GetSurvey(GetSurveyRequest request)
        {
            (string response, string requestUrl) = await SendQualtricsGetRequestAsync(
                ApiRoutes.Surveys.GetSurvey
                .Replace("{surveyId}", request.SurveyID)
                );

            GetSurveyResponseDto responseDto = JsonConvert.DeserializeObject<GetSurveyResponseDto>(response);
            responseDto.RequestUrl = requestUrl;
            responseDto.Request = JsonConvert.SerializeObject(request);
            return responseDto;
        }

        public async Task<ListSurveysResponseDto> ListSurveys(ListSurveysRequest request)
        {
            (string response, string requestUrl) = await SendQualtricsGetRequestAsync(
                ApiRoutes.Surveys.ListSurveys);

            ListSurveysResponseDto responseDto = JsonConvert.DeserializeObject<ListSurveysResponseDto>(response);
            responseDto.RequestUrl = requestUrl;
            responseDto.Request = JsonConvert.SerializeObject(request);
            return responseDto;
        }
    }
}
