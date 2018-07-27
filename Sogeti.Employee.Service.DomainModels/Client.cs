using System;
using System.Collections.Generic;

namespace Sogeti.Employee.Service.DomainModels
{
    public class Client
    {
        public string CompanyName { get; set; }
        public string Location { get; set; }
        public List<Project> Projects { get; set; }
    }
}
