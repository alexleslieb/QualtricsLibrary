using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Contacts.SearchDirectoryContacts
{
    public class SearchDirectoryContactsResponseStats
    {
        public string AvgTimeToRespond { get; set; }
        public string DataIntegrity { get; set; }
        public string EmailCount { get; set; }
        public string InviteCount { get; set; }
        public DateTime? LastEmailDate { get; set; }
        public DateTime? LastInviteDate { get; set; }
        public DateTime? LastResponseDate { get; set; }
        public string MonthEmailCount { get; set; }
        public string MonthInviteCount { get; set; }
        public string Points { get; set; }
        public string ResponseCount { get; set; }
        public string ResponseRate { get; set; }
    }
}
