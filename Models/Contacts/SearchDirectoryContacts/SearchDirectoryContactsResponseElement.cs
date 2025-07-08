using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Contacts.SearchDirectoryContacts
{
    public class SearchDirectoryContactsResponseElement
    {
        public string id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string language { get; set; }
        public string externalDataReference { get; set; }
        public bool unsubscribed { get; set; }
        public DateTime? unsubscribeDate { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime lastModified { get; set; }
        public string segmentMembership { get; set; }
        public SearchDirectoryContactsResponseStats stats { get; set; }
    }
}
