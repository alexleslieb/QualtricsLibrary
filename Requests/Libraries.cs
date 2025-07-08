using Newtonsoft.Json;
using QualtricsClassLibrary.Interfaces;
using QualtricsWebAPI.QualtricsClassLibrary.Models.Libraries.Libraries;
using QualtricsWebAPI.QualtricsClassLibrary.Routes;

namespace QualtricsWebAPI.QualtricsClassLibrary.Requests
{
    public class Libraries : Request, ILibraries
    {
        public Libraries(string baseUrl, string authenticationToken) : base(baseUrl, authenticationToken) { }

        public async Task<ListLibrariesResponseDto> ListLibraries(ListLibrariesRequest request)
        {
            (string response, string requestUrl) = await SendQualtricsGetRequestAsync(
                ApiRoutes.Libraries.ListLibraries
                );

            ListLibrariesResponseDto responseDto = JsonConvert.DeserializeObject<ListLibrariesResponseDto>(response);
            responseDto.RequestUrl = requestUrl;
            responseDto.Request = JsonConvert.SerializeObject(request);
            return responseDto;
        }
    }
}
