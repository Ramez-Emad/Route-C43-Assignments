using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_Assignment04
{
    class Club
    {
        public int ClubID { get; set; }
        public String ClubName { get; set; }

        List<Employee> Members;
        public Club()
        {
            Members = new List<Employee>();
        }

        public void AddMember(Employee E)
        {

            if (E != null)
            {
                Members.Add(E);
                E.EmployeeLayOff += this.RemoveMember;
            }

        }
        public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {


            if (sender is Employee Emp && Members.Contains(Emp) && e.Cause == LayOffCause.VacationStockLimit)
            {
                Console.WriteLine($"{Emp} Has Been Removed From Club {this.ClubName} because of {e.Cause}");
                Members.Remove(Emp);
            }

        }
    }

}
