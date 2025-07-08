

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Surveys.GetSurvey
{
    public class GetSurveyResponseResult
    {
        public string id { get; set; }
        public string name { get; set; }
        public string ownerId { get; set; }
        public string organizationId { get; set; }
        public bool isActive { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime lastModifiedDate { get; set; }
        public GetSurveyResponseExpiration expiration { get; set; }
        public GetSurveyResponseQuestion questions { get; set; }
    }
}
