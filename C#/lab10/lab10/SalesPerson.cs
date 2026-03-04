using System;
using System.Collections.Generic;
using System.Text;

namespace lab10
{
    internal class SalesPerson :Employee
    {
        public int AchievedTarget { get; set; }
        public bool CheckTarget(int Quota)
        {
            if (AchievedTarget < Quota)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.FailedToAchieveTarget });
                return false;
            }
            return true;
        }

        public override bool RequestVacation(DateTime From, DateTime To)
        {
            return true;
        }

    }



    public class BoardMember : Employee
    {
        public override void EndOfYearOperation()
        {
            
        }

        public override bool RequestVacation(DateTime From, DateTime To)
        {
            return true;
        }

        public void Resign()
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.Resigned });
        }
    }
}
