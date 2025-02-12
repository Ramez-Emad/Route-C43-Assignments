using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ADV_Assignment04
{
    class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs>? EmployeeLayOff;

        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
        }

        public int EmployeeID { get; set; }
        public DateTime BirthDate { get; set; }

        private int _vacationStock;
        public virtual int VacationStock
        {
            get => _vacationStock;
            set 
            {
               if (value < 0)
               {
                   OnEmployeeLayOff( new EmployeeLayOffEventArgs() { Cause = LayOffCause.VacationStockLimit});
               }
                _vacationStock = value;
            }
        }
        public bool RequestVacation(DateTime From, DateTime To)
        {
            int days = To.Day - From.Day;
            VacationStock -= (To.Day - From.Day);
            return (days <= VacationStock);
        }
        public void EndOfYearOperation()
        {
            int Age = DateTime.Now.Year - BirthDate.Year;
            if (Age >= 60)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.AgeLimit });
                Console.WriteLine($"Employee ID: {EmployeeID}, has Been Layed Off");
            }
        }
        override public string ToString()
        {
            return $"Employee ID: {EmployeeID}, Birth Date: {BirthDate}, Vacation Stock: {VacationStock}";
        }
    }
    public enum LayOffCause
    { 
        VacationStockLimit,
        AgeLimit,
        Resigned,
        TargetUnAchieved
    }
    public class EmployeeLayOffEventArgs : EventArgs
    {
        public LayOffCause Cause { get; set; }
    }

}
