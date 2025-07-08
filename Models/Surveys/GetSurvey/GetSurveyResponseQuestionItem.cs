

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Surveys.GetSurvey
{
    public class GetSurveyResponseQuestionItem
    {
        public GetSurveyResponseQuestionType questionType { get; set; }
        public string questionText { get; set; }
        public string questionLabel { get; set; }
        public GetSurveyResponseQuestionItemValidation validation { get; set; }
        public string questionName { get; set; }
    }
}
