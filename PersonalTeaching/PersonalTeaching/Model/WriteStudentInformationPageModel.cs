using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalTeaching.Model
{
    public class WriteStudentInformationPageModel
    {
        public string Si { get; set; }
        public string Gu { get; set; }
        public string Dong { get; set; }
        public string Grade { get; set; }
        public int GradePrice { get; set; }
        public int TotalPrice { get; set; }
        public string TotalPriceString { get; set; }
        public string SchoolName { get; set; } = "학교찾기";
        public List<string> Options { get; set; }

    }
}
