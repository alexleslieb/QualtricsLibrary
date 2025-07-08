
using QualtricsWebAPI.QualtricsClassLibrary.Models.Directories.ListDirectories;

namespace QualtricsClassLibrary.Interfaces
{
    public interface IDirectories
    {
        public Task<ListDirectoriesResponseDto> ListDirectories(ListDirectoriesRequest request);
    }
}
