using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Directories.ListDirectories
{
    public class ListDirectoriesResponseResultDeduplicationCriteria
    {
        public bool email { get; set; }
        public bool firstName { get; set; }
        public bool lastName { get; set; }
        public bool externalDataReference { get; set; }
        public bool phone { get; set; }
    }
}
