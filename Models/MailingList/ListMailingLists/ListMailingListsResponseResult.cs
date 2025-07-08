using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.MailingList.ListMailingLists
{
    public class ListMailingListsResponseResult
    {
        public List<ListMailingListsResponseElement> elements { get; set; }
        public string nextPage { get; set; }
    }
}
