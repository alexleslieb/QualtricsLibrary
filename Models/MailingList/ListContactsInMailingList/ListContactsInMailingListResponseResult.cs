using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.MailingList.ListContactsInMailingList
{
    public class ListContactsInMailingListResponseResult
    {
        public List<ListContactsInMailingListResponseElement> elements { get; set; }
        public string nextPage { get; set; }
    }
}
