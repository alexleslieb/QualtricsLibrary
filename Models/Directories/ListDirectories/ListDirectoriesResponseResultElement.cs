using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Directories.ListDirectories
{
    public class ListDirectoriesResponseResultElement
    {
        public string directoryId { get; set; }
        public string name { get; set; }
        public int contactCount { get; set; }
        public bool isDefault { get; set; }
        public ListDirectoriesResponseResultDeduplicationCriteria deduplicationCriteria { get; set; }
    }
}
