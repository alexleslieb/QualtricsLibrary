using Newtonsoft.Json;
using QualtricsClassLibrary.Interfaces;
using QualtricsWebAPI.QualtricsClassLibrary.Models.Contacts.CreateDirectoryContact;
using QualtricsWebAPI.QualtricsClassLibrary.Models.Contacts.DeleteDirectoryContact;
using QualtricsWebAPI.QualtricsClassLibrary.Models.Contacts.GetDirectoryContact;
using QualtricsWebAPI.QualtricsClassLibrary.Models.Contacts.GetDirectoryContacts;
using QualtricsWebAPI.QualtricsClassLibrary.Models.Contacts.SearchDirectoryContacts;
using QualtricsWebAPI.QualtricsClassLibrary.Models.Contacts.UpdateDirectoryContact;
using QualtricsWebAPI.QualtricsClassLibrary.Routes;

namespace QualtricsWebAPI.QualtricsClassLibrary.Requests
{
    public class DirectoryContacts : Request, IDirectoryContacts
    {
        public DirectoryContacts(string baseUrl, string authenticationToken) : base(baseUrl, authenticationToken) { }

        public async Task<GetDirectoryContactsResponseDto> GetDirectoryContacts(GetDirectoryContactsRequest request)
        {
            (string response, string requestUrl) = await SendQualtricsGetRequestAsync(
                ApiRoutes.DirectoryContacts.GetDirectoryContacts
                .Replace("{directoryId}", request.DirectoryID)
                );

            GetDirectoryContactsResponseDto responseDto =  JsonConvert.DeserializeObject<GetDirectoryContactsResponseDto>(response);
            responseDto.RequestUrl = requestUrl;
            responseDto.Request = JsonConvert.SerializeObject(request);
            return responseDto;
        }

        public async Task<GetDirectoryContactResponseDto> GetDirectoryContact(GetDirectoryContactRequest request)
        {
            (string response, string requestUrl) = await SendQualtricsGetRequestAsync(
                ApiRoutes.DirectoryContacts.GetDirectoryContact
                .Replace("{directoryId}", request.DirectoryID)
                .Replace("{contactId}", request.ContactID)
                );

            GetDirectoryContactResponseDto responseDto = JsonConvert.DeserializeObject<GetDirectoryContactResponseDto>(response);
            responseDto.RequestUrl = requestUrl;
            responseDto.Request = JsonConvert.SerializeObject(request);
            return responseDto;
        }

        public async Task<CreateDirectoryContactResponseDto> CreateDirectoryContact(CreateDirectoryContactRequest request)
        {
            (string response, string requestUrl) = await SendQualtricsPostRequestAsync(
                ApiRoutes.DirectoryContacts.CreateDirectoryContact
                .Replace("{directoryId}", request.DirectoryID),
                JsonConvert.SerializeObject(request.Body)
                );

            CreateDirectoryContactResponseDto responseDto = JsonConvert.DeserializeObject<CreateDirectoryContactResponseDto>(response);
            responseDto.RequestUrl = requestUrl;
            responseDto.Request = JsonConvert.SerializeObject(request);
            return responseDto;
        }

        public async Task<DeleteDirectoryContactResponseDto> DeleteDirectoryContact(DeleteDirectoryContactRequest request)
        {
            (string response, string requestUrl) = await SendQualtricsDeleteRequestAsync(
                ApiRoutes.DirectoryContacts.DeleteDirectoryContact
                .Replace("{directoryId}", request.DirectoryID)
                .Replace("{contactId}", request.ContactID)
                );

            DeleteDirectoryContactResponseDto responseDto = JsonConvert.DeserializeObject<DeleteDirectoryContactResponseDto>(response);
            responseDto.RequestUrl = requestUrl;
            responseDto.Request = JsonConvert.SerializeObject(request);
            return responseDto;
        }

        public async Task<UpdateDirectoryContactsResponseDto> UpdateDirectoryContact(UpdateDirectoryContactRequest request)
        {
            (string response, string requestUrl) = await SendQualtricsPutRequestAsync(
                ApiRoutes.DirectoryContacts.UpdateDirectoryContact
                .Replace("{directoryId}", request.DirectoryID)
                .Replace("{contactId}", request.ContactID), 
                JsonConvert.SerializeObject(request.Body)
                );

            UpdateDirectoryContactsResponseDto responseDto = JsonConvert.DeserializeObject<UpdateDirectoryContactsResponseDto>(response);
            responseDto.RequestUrl = requestUrl;
            responseDto.Request = JsonConvert.SerializeObject(request);
            return responseDto;
        }

        public async Task<SearchDirectoryContactsResponseDto> SearchDirectoryContacts(SearchDirectoryContactsRequest request)
        {
            (string response, string requestUrl) = await SendQualtricsPostRequestAsync(
                ApiRoutes.DirectoryContacts.SearchDirectoryContacts
                .Replace("{directoryId}", request.DirectoryID),
                JsonConvert.SerializeObject(request.Body)
                );

            SearchDirectoryContactsResponseDto responseDto = JsonConvert.DeserializeObject<SearchDirectoryContactsResponseDto>(response);
            responseDto.RequestUrl = requestUrl;
            responseDto.Request = JsonConvert.SerializeObject(request);
            return responseDto;
        }
    }
}
