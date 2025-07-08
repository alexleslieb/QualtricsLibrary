using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Contacts.SearchDirectoryContacts
{
    public class SearchDirectoryContactsRequest
    {
        public string DirectoryID { get; set; }
        public SearchDirectoryContactsRequestBody Body { get; set; }
    }
}
