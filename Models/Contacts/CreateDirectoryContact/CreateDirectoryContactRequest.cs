using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Contacts.CreateDirectoryContact
{
    public class CreateDirectoryContactRequest
    {
        public string DirectoryID { get; set; }
        public CreateDirectoryContactRequestBody Body { get; set; }
    }
}
