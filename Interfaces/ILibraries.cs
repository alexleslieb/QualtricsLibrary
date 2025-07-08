using QualtricsWebAPI.QualtricsClassLibrary.Models.Libraries.Libraries;

namespace QualtricsClassLibrary.Interfaces
{
    public interface ILibraries
    {
        public Task<ListLibrariesResponseDto> ListLibraries(ListLibrariesRequest request);
    }
}
