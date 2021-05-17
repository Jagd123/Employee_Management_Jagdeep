using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management_Jagdeep.Models
{
    public class EmployeeDetail
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public int DepartmentID { get; set; }
        public int DesignationID { get; set; }

        public Designation Designation { get; set; }
        public Department Department { get; set; }

    }
}
