using QualtricsWebAPI.QualtricsClassLibrary.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Directories.ListDirectories
{
    public class ListDirectoriesResponseDto: ResponseDto
    {
        public ListDirectoriesResponseResult result { get; set; }
    }
}
