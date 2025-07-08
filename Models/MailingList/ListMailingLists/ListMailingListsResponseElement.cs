using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.MailingList.ListMailingLists
{
    public class ListMailingListsResponseElement
    {
        public int contactCount { get; set; }
        public string mailingListId { get; set; }
        public string name { get; set; }
        public long lastModifiedDate { get; set; }
        public long creationDate { get; set; }
        public string ownerId { get; set; }
    }
}
