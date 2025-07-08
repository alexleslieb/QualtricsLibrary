namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Common
{
    public class MetaDto
    {
        public string requestId { get; set; }
        public string httpStatus { get; set; }
        public ErrorDto error { get; set; }
    }
}
