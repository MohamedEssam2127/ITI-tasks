using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lab10
{
      public class Club
    {
        public int ClubID { get; set; }
        public String ClubName { get; set; }
        List<Employee> Members = new List<Employee>();
        public void AddMember(Employee E)
        {
           Members.Add(E);
            E.EmployeeLayOff += RemoveMember;
        }
        ///CallBackMethod 
        public void RemoveMember (object sender, EmployeeLayOffEventArgs e) {
            if (sender is Employee emp && e.Cause == LayOffCause.VacationStockLessThanZero)
            {
                if (emp is BoardMember) return;
                Members.Remove(emp);
                emp.EmployeeLayOff -= RemoveMember;
                Console.WriteLine($"Employee {emp.EmployeeID} removed from Club {ClubName} due to {e.Cause}");
            }
            ///Employee Will not be removed from the Club if Age>60 
            ///Employee will be removed from Club if Vacation Stock < 0 
        }

        public void ShowMembers()
        {
            Console.WriteLine($" Club  {ClubName} Staff:");
            foreach (var emp in Members)
            {
                Console.WriteLine($"- EmployeeID: {emp.EmployeeID}");
            }
        }
    }
}
