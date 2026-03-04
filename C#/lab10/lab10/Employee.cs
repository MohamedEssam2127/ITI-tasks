using System;
using System.Collections.Generic;
using System.Text;

namespace lab10
{
    class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;

        protected virtual void OnEmployeeLayOff (EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke (this, e);
        }

        public int EmployeeID { get; set; }

        public DateTime BirthDate { get; set; }

        public int VacationStock { get; set; }

        public bool RequestVacation(DateTime From, DateTime To)
        {
            int temp = (To - From).Days;
            if (temp > 0) {
               VacationStock -= temp;
                if (VacationStock < 0)
                {
                    OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.VacationStockLessThanZero });
                    return false;
                }
                return true;
            }
            return false;
        }

        public void EndOfYearOperation()
        {
            int age = DateTime.Now.Year - BirthDate.Year;

            if (age > 60)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs{Cause = LayOffCause.AgeAboveSixty});
            }
        }

    }
    
    public class EmployeeLayOffEventArgs
    {
        public LayOffCause Cause { get; set; }
    }
     public  enum LayOffCause
    {
        VacationStockLessThanZero,
        AgeAboveSixty,
        FailedToAchieveTarget,
        Resigned
    }
}
