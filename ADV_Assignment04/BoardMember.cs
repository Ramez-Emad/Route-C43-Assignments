using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_Assignment04
{
    internal class BoardMember : Employee
    {
        public override int VacationStock { get; set; }
        public void Resign()
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.Resigned });
            Console.WriteLine($"{this} Had Resigned");

        }
        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if (e.Cause != LayOffCause.Resigned) return;
            base.OnEmployeeLayOff(e);
        }
    }
}
