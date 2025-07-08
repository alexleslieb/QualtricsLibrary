using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Contacts.GetDirectoryContacts
{
    public class GetDirectoryContactsResponseResult
    {
        public List<GetDirectoryContactsResponseResultElement> elements { get; set; }
        public string nextPage { get; set; }
    }
}
