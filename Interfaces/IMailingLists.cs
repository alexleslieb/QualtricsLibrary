using QualtricsWebAPI.QualtricsClassLibrary.Models.MailingList.CreateContactInMailingList;
using QualtricsWebAPI.QualtricsClassLibrary.Models.MailingList.GetContactInMailingList;
using QualtricsWebAPI.QualtricsClassLibrary.Models.MailingList.GetMailingList;
using QualtricsWebAPI.QualtricsClassLibrary.Models.MailingList.ListContactsInMailingList;
using QualtricsWebAPI.QualtricsClassLibrary.Models.MailingList.ListMailingLists;

namespace QualtricsClassLibrary.Interfaces
{
    public interface IMailingLists
    {
        public Task<CreateContactInMailingListResponseDto> CreateContactInMailingList(CreateContactInMailingListRequest request);
        public Task<GetContactInMailingListResponseDto> GetContactInMailingList(GetContactInMailingListRequest request);
        public Task<GetMailingListResponseDto> GetMailingList(GetMailingListRequest request);
        public Task<ListMailingListsResponseDto> ListMailingLists(ListMailingListsRequest request);
        public Task<ListContactsInMailingListResponseDto> ListContactsInMailingLists(ListContactsInMailingListRequest request);
    }
}
