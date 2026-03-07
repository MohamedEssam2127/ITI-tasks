using LAB_7.Exam;

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
        public void OnExamStarted(object sender, ExamEventArgs e)
        {
            Console.WriteLine($"Notification for {Name}: The exam for {e.Subject.Name} has started!");
        }
    }

    public class Subject
    {
        public string Name { get; set; }
        public List<Student> EnrolledStudents { get; set; }

        public Subject(string name, int capacity)
        {
            Name = name;
            EnrolledStudents = new List<Student>(capacity);
        }

        public void Enroll(Student student)
        {
            if (student == null) throw new ArgumentNullException(nameof(student));
            EnrolledStudents.Add(student);
        }
    }
}