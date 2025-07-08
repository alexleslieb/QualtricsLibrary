
using QualtricsWebAPI.QualtricsClassLibrary.Models.Contacts.CreateDirectoryContact;
using QualtricsWebAPI.QualtricsClassLibrary.Models.Contacts.DeleteDirectoryContact;
using QualtricsWebAPI.QualtricsClassLibrary.Models.Contacts.GetDirectoryContact;
using QualtricsWebAPI.QualtricsClassLibrary.Models.Contacts.GetDirectoryContacts;
using QualtricsWebAPI.QualtricsClassLibrary.Models.Contacts.SearchDirectoryContacts;
using QualtricsWebAPI.QualtricsClassLibrary.Models.Contacts.UpdateDirectoryContact;

namespace QualtricsClassLibrary.Interfaces
{
    public interface IDirectoryContacts
    {
        public Task<GetDirectoryContactsResponseDto> GetDirectoryContacts(GetDirectoryContactsRequest request);
        public Task<GetDirectoryContactResponseDto> GetDirectoryContact(GetDirectoryContactRequest request);
        public Task<CreateDirectoryContactResponseDto> CreateDirectoryContact(CreateDirectoryContactRequest request);
        public Task<DeleteDirectoryContactResponseDto> DeleteDirectoryContact(DeleteDirectoryContactRequest request);
        public Task<UpdateDirectoryContactsResponseDto> UpdateDirectoryContact(UpdateDirectoryContactRequest request);
        public Task<SearchDirectoryContactsResponseDto> SearchDirectoryContacts(SearchDirectoryContactsRequest request);
    }
}
