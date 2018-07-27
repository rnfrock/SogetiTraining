using System;

namespace Sogeti.Employee.Service.DomainModels
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime SogetiStartDate { get; set; }
        public string Level { get; set; }
        public Client CurrentClient { get; set; }
        public object Contract { get; set; }
    }
}
