using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_Assignment04
{
    class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }

        List<Employee> Staff;

        public Department()
        {
            Staff = new List<Employee>();
        }
        public void AddStaff(Employee E)
        {
            if (E is not null)
            {
                Staff.Add(E);
                E.EmployeeLayOff += RemoveStaff;
            }
        }

        ///CallBackMethod
        public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
        {
            if (sender is Employee E)
            {
                Staff.Remove(E);
                Console.WriteLine($"{E} Has Been Removed From Department {this.DeptName} because of {e.Cause}");
            }
        }
    }

}
