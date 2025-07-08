using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Contacts.DeleteDirectoryContact
{
    public class DeleteDirectoryContactRequest
    {
        public string DirectoryID { get; set; }
        public string ContactID { get; set; }
    }
}
