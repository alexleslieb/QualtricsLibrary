using QualtricsWebAPI.QualtricsClassLibrary.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.MailingList.GetMailingList
{
    public class GetMailingListResponseDto: ResponseDto
    {
        public GetMailingListResponseResult result { get; set; }
    }
}
