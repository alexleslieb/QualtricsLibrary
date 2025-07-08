using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Contacts.CreateDirectoryContact
{
    public class CreateDirectoryContactRequestBody
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        //embedded data
        public string language { get; set; }
        public string extRef { get; set; }
        public bool unsubscribed { get; set; }
    }
}
