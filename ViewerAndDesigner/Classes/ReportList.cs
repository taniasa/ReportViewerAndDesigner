using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewerAndDesigner.Classes
{
    public class ReportList
    {
        public ReportList(int sequence, string name, string description, DataReportEnum data)
        {
            Sequence = sequence;
            Name = name;
            Description = description;
            Data = data;
        }
        public ReportList()
        {

        }
        public int Sequence { get; set; }
        public string Controller { get; set; } = "Viewer";
        public string Name { get; set; }
        public string Description { get; set; }
        public DataReportEnum Data { get; set; }
    }
}