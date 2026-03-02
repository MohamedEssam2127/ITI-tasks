using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_7.Core
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
    public class Subject
    {
        public string Name { get; set; }
        public Student[] EnrolledStudents { get; set; }
        private int _count;

        public Subject(string name, int capacity)
        {
            Name = name;
            EnrolledStudents = new Student[capacity];
            _count = 0;
        }

        public void Enroll(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(nameof(student));
            }

            if (_count < EnrolledStudents.Length)
            {
                EnrolledStudents[_count] = student;
                _count++;
            }
        }
    }
}
