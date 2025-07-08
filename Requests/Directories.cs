using Newtonsoft.Json;
using QualtricsClassLibrary.Interfaces;
using QualtricsWebAPI.QualtricsClassLibrary.Models.Directories.ListDirectories;
using QualtricsWebAPI.QualtricsClassLibrary.Routes;

namespace QualtricsWebAPI.QualtricsClassLibrary.Requests
{
    public class Directories : Request, IDirectories
    {
        public Directories(string baseUrl, string authorizationToken): base(baseUrl, authorizationToken) { }

        public async Task<ListDirectoriesResponseDto> ListDirectories(ListDirectoriesRequest request)
        {
            (string response, string requestUrl) = await SendQualtricsGetRequestAsync(
                ApiRoutes.Directories.GetDirectories
                );

            ListDirectoriesResponseDto responseDto = JsonConvert.DeserializeObject<ListDirectoriesResponseDto>(response);
            responseDto.RequestUrl = requestUrl;
            responseDto.Request = JsonConvert.SerializeObject(request);
            return responseDto;
        }
    }
}
