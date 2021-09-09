using System;
using System.Collections.Generic;

#nullable disable

namespace HandsonentityFramworkdoing.Entities
{
    public partial class Employee1
    {
        public string EmpNo { get; set; }
        public string FirstName { get; set; }
        public int? Department { get; set; }
        public int? DeptCode { get; set; }
        public string LastName { get; set; }
        public decimal? Salary { get; set; }
    }
}
