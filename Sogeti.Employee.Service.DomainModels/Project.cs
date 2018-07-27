using System;
using System.Collections.Generic;

namespace Sogeti.Employee.Service.DomainModels
{
    public class Project
    {
        public string ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ProjectedEndDate { get; set; }
        public List<string> TechStack { get; set; }
    }
}
