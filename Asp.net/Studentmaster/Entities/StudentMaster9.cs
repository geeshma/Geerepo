using System;
using System.Collections.Generic;

#nullable disable

namespace Studentmaster.Entities
{
    public partial class StudentMaster9
    {
        public decimal StudCode { get; set; }
        public string StudName { get; set; }
        public decimal? DeptCode { get; set; }
        public DateTime? StudDob { get; set; }
        public string Address { get; set; }

        public virtual DepartmentMaster DeptCodeNavigation { get; set; }
    }
}
