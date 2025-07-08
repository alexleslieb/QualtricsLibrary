using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualtricsWebAPI.QualtricsClassLibrary.Models.Surveys.ListSurveys
{
    public class ListSurveysResponseResult
    {
        public List<ListSurveysResponseResultElement> elements { get; set; }
        public string nextPage { get; set; }
    }
}
