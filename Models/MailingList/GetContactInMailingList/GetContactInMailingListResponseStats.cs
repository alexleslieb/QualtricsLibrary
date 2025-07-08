using QualtricsWebAPI.QualtricsClassLibrary.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.MailingList.GetContactInMailingList
{
    public class GetContactInMailingListResponseStats
    {
        public string MonthInviteCount { get; set; }
        public DateTime LastEmailDate { get; set; }
        public DateTime LastInviteDate { get; set; }
        public string ResponseRate { get; set; }
        public string InviteCount { get; set; }
        public string LastResponseDate { get; set; }
        public string EmailCount { get; set; }
        public string ResponseCount { get; set; }
        public string AvgTimeToRespond { get; set; }
        public string MonthEmailCount { get; set; }
    }
}
