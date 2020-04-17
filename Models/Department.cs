using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testaegona.Models
{
    public class Department
    {
        public Department(int id, string departmentName)
        {
            Id = id;
            DepartmentName = departmentName;
        }
        public Department()
        {
           
        }

        public int Id { set; get; }
        public string DepartmentName { set; get; }
    }

}
