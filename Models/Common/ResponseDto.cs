using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Common
{
    public class ResponseDto
    {
        public string RequestUrl { get; set; } = "";
        public string Request { get; set; } = "";
        public MetaDto meta { get; set; }
    }
}
