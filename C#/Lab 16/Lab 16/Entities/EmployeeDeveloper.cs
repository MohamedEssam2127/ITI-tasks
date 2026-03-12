using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_16.Entities
{
    public   partial  class Employee
    {
        public override string ToString()
        {
            return $" emp id {EmpId} ,{Fname}  ,{Lname}";
        }
    }
}
