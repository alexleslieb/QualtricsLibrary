
using QualtricsWebAPI.QualtricsClassLibrary.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Libraries.Libraries
{
    public class ListLibrariesResponseDto: ResponseDto
    {
        public ListLibrariesResponseResult result { get; set; }
    }
}
