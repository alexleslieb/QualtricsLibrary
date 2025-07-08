
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.MailingList.GetContactInMailingList
{
    public class GetContactInMailingListRequest
    {
        public string DirectoryID { get; set; }
        public string MailingListID { get; set; }
        public string ContactID { get; set; }
    }
}
