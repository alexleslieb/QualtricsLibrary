﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.MailingList.ListContactsInMailingList
{
    public class ListContactsInMailingListRequest
    {
        public string DirectoryID { get; set; }
        public string MailingListID { get; set; }
    }
}
