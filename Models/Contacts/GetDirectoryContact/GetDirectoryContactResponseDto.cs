using QualtricsWebAPI.QualtricsClassLibrary.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Contacts.GetDirectoryContact
{
    public class GetDirectoryContactResponseDto: ResponseDto
    {
        public GetDirectoryContactResponseResultDto result { get; set; }
    }
}
