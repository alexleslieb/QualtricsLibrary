using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Contacts.GetDirectoryContact
{
    public class GetDirectoryContactResponseResultDto
    {
        public string contactId { get; set; }
        public long creationDate { get; set; }
        public long lastModified { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string emailDomain { get; set; }
        public string phone { get; set; }
        public string extRef { get; set; }
        public string language { get; set; }
        public bool directoryUnsubscribed { get; set; }
        //Add embedded data
        public GetDirectoryContactResponseStats stats { get; set; }
        //Add mailing list membership
    }
}
