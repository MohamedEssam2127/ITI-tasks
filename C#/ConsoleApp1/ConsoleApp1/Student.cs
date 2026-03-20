using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Student:IComparable<Student>
    {
        public string Name { get; set; }
        public int Grade { get; set; }

        public int CompareTo(Student other)
        {
            return Grade.CompareTo(other.Grade);
        }


    }
}
