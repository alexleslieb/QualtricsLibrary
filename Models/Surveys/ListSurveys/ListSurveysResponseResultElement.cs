using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Surveys.ListSurveys
{
    public class ListSurveysResponseResultElement
    {
        public string id { get; set; }
        public string name { get; set; }
        public string ownerId { get; set; }
        public DateTime lastModified { get; set; }
        public DateTime creationDate { get; set; }
        public bool isActive { get; set; }
    }
}
