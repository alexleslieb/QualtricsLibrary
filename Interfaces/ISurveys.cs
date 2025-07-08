using QualtricsWebAPI.QualtricsClassLibrary.Models.Surveys.GetSurvey;
using QualtricsWebAPI.QualtricsClassLibrary.Models.Surveys.ListSurveys;

namespace QualtricsClassLibrary.Interfaces
{
    public interface ISurveys
    {
        public Task<GetSurveyResponseDto> GetSurvey(GetSurveyRequest request);
        public Task<ListSurveysResponseDto> ListSurveys(ListSurveysRequest request);
    }
}
