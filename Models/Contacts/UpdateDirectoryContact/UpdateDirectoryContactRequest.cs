using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Contacts.UpdateDirectoryContact
{
    public class UpdateDirectoryContactRequest
    {
        public string DirectoryID { get; set; }
        public string ContactID { get; set; }
        public UpdateDirectoryContactRequestBody Body { get; set; }
    }
}
