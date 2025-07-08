using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Contacts.GetDirectoryContacts
{
    public class GetDirectoryContactsResponseResultElement
    {
        public string contactId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string extRef { get; set; }
        public string language { get; set; }
        public bool unsubscribed { get; set; }
        //put embeddeddata
    }
}
