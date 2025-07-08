using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.MailingList.GetContactInMailingList
{
    public class GetContactInMailingListResponseResult
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
        //embedded data
        public string language { get; set; }
        public bool directoryUnsubscribed { get; set; }
        public string directoryUnsubscribeDate { get; set; }
        public bool mailingListUnsubscribed { get; set; }
        public string mailingListUnsubscribeDate { get; set; }
        public GetContactInMailingListResponseStats stats { get; set; }
        public string contactLookupId { get; set; }
    }
}
