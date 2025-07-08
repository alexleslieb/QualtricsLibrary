namespace QualtricsWebAPI.QualtricsClassLibrary.Models.MailingList.CreateContactInMailingList
{
    public class CreateContactInMailingListRequest
    {
        public string DirectoryID { get; set; }
        public string MailingListID { get; set; }
        public CreateContactInMailingListRequestBody Body { get; set; }
    }
}
