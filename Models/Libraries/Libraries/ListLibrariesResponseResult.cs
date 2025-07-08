using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Libraries.Libraries
{
    public class ListLibrariesResponseResult
    {
        public List<ListLibrariesResponseResultElement> elements { get; set; }
        public string nextPage { get; set; }
    }
}
