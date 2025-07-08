using Newtonsoft.Json;
using QualtricsWebAPI.QualtricsClassLibrary.Models.MailingList.ListMailingLists;
using QualtricsWebAPI.QualtricsClassLibrary.Models.MailingList.CreateContactInMailingList;
using QualtricsWebAPI.QualtricsClassLibrary.Models.MailingList.GetContactInMailingList;
using QualtricsWebAPI.QualtricsClassLibrary.Models.MailingList.GetMailingList;
using QualtricsWebAPI.QualtricsClassLibrary.Routes;
using QualtricsWebAPI.QualtricsClassLibrary.Models.MailingList.ListContactsInMailingList;
using QualtricsClassLibrary.Interfaces;

namespace QualtricsWebAPI.QualtricsClassLibrary.Requests
{
    public class MailingLists : Request, IMailingLists
    {
        public MailingLists(string baseUrl, string authenticationToken) : base(baseUrl, authenticationToken) { }

        public async Task<CreateContactInMailingListResponseDto> CreateContactInMailingList(CreateContactInMailingListRequest request)
        {
            (string response, string requestUrl) = await SendQualtricsPostRequestAsync(
                ApiRoutes.MailingListContacts.CreateContactInMailingList
                .Replace("{directoryId}", request.DirectoryID)
                .Replace("{mailingListId}", request.MailingListID)
                , JsonConvert.SerializeObject(request.Body)
                );

            CreateContactInMailingListResponseDto responseDto = JsonConvert.DeserializeObject<CreateContactInMailingListResponseDto>(response);
            responseDto.RequestUrl = requestUrl;
            responseDto.Request = JsonConvert.SerializeObject(request);
            return responseDto;
        }

        public async Task<GetContactInMailingListResponseDto> GetContactInMailingList(GetContactInMailingListRequest request)
        {
            (string response, string requestUrl) = await SendQualtricsGetRequestAsync(
                ApiRoutes.MailingListContacts.GetContactInMailingList
                .Replace("{directoryId}", request.DirectoryID)
                .Replace("{mailingListId}", request.MailingListID)
                .Replace("{contactId}", request.ContactID)
                );

            GetContactInMailingListResponseDto responseDto = JsonConvert.DeserializeObject<GetContactInMailingListResponseDto>(response);
            responseDto.RequestUrl = requestUrl;
            responseDto.Request = JsonConvert.SerializeObject(request);
            return responseDto;
        }

        public async Task<GetMailingListResponseDto> GetMailingList(GetMailingListRequest request)
        {
            (string response, string requestUrl) = await SendQualtricsGetRequestAsync(
                ApiRoutes.MailingLists.GetMailingList
                .Replace("{directoryId}", request.DirectoryID)
                .Replace("{mailingListId}", request.MailingListID)
                );

            GetMailingListResponseDto responseDto = JsonConvert.DeserializeObject<GetMailingListResponseDto>(response);
            responseDto.RequestUrl = requestUrl;
            responseDto.Request = JsonConvert.SerializeObject(request);
            return responseDto;
        }

        public async Task<ListMailingListsResponseDto> ListMailingLists(ListMailingListsRequest request)
        {
            (string response, string requestUrl) = await SendQualtricsGetRequestAsync(
                ApiRoutes.MailingLists.GetMailingLists
                .Replace("{directoryId}", request.DirectoryID)
                );

            ListMailingListsResponseDto responseDto = JsonConvert.DeserializeObject<ListMailingListsResponseDto>(response);
            responseDto.RequestUrl = requestUrl;
            responseDto.Request = JsonConvert.SerializeObject(request);
            return responseDto;
        }

        public async Task<ListContactsInMailingListResponseDto> ListContactsInMailingLists(ListContactsInMailingListRequest request)
        {
            (string response, string requestUrl) = await SendQualtricsGetRequestAsync(
                ApiRoutes.MailingLists.ListContactsInMailingList
                .Replace("{directoryId}", request.DirectoryID)
                .Replace("{mailingListId}", request.MailingListID)
                );

            ListContactsInMailingListResponseDto responseDto = JsonConvert.DeserializeObject<ListContactsInMailingListResponseDto>(response);
            responseDto.RequestUrl = requestUrl;
            responseDto.Request = JsonConvert.SerializeObject(request);
            return responseDto;
        }
    }
}
