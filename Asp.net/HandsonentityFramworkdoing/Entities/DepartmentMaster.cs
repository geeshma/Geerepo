using System;
using System.Collections.Generic;

#nullable disable

namespace HandsonentityFramworkdoing.Entities
{
    public partial class DepartmentMaster
    {
        public DepartmentMaster()
        {
            StaffMasters = new HashSet<StaffMaster>();
            StudentMaster9s = new HashSet<StudentMaster9>();
            StudentMasters = new HashSet<StudentMaster>();
        }

        public decimal DeptCode { get; set; }
        public string DeptName { get; set; }

        public virtual ICollection<StaffMaster> StaffMasters { get; set; }
        public virtual ICollection<StudentMaster9> StudentMaster9s { get; set; }
        public virtual ICollection<StudentMaster> StudentMasters { get; set; }
    }
}
