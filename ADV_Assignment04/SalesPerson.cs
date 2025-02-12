using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_Assignment04
{
    internal class SalesPerson : Employee
    {
        public override int VacationStock { get; set; }
        public int AchievedTarget { get; set; }
        public bool CheckTarget(int Quota)
        {
            if (Quota < AchievedTarget)
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.TargetUnAchieved });
            return Quota >= AchievedTarget;
        }
        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if (e.Cause == LayOffCause.VacationStockLimit) return;
            base.OnEmployeeLayOff(e);
        }
    }
}
