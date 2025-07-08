using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Directories.ListDirectories
{
    public class ListDirectoriesResponseResult
    {
        public List<ListDirectoriesResponseResultElement> elements { get; set; }
        public string nextPage { get; set; }
    }
}
