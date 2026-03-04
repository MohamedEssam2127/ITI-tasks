using System;
using System.Collections.Generic;
using System.Text;

namespace lab10
{
    class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        List<Employee> Staff = new List<Employee>();
        public void AddStaff(Employee E)
        {
           Staff.Add(E);
            E.EmployeeLayOff += RemoveStaff;
        }
        ///CallBackMethod 
        public void RemoveStaff(object sender,EmployeeLayOffEventArgs e)
        {
            if (sender is Employee emp)
            {
                Staff.Remove(emp);
                Console.WriteLine($"Employee {emp.EmployeeID} removed from Department {DeptName} due to {e.Cause}");
            }

        }
        public void ShowStaff()
        {
            Console.WriteLine($"Department {DeptName} Staff:");
            foreach (var emp in Staff)
            {
                Console.WriteLine($"- EmployeeID: {emp.EmployeeID}");
            }
        }
    }

}
