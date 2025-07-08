using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Contacts.SearchDirectoryContacts
{
    public class SearchDirectoryContactsRequestBodyFilter
    {
        public string filterType { get; set; }
        public string comparison { get; set; }
        public string value { get; set; }
    }
}
