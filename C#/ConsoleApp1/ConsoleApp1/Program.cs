namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>()
        {
            new Student { Name="Ali", Grade=80 },
            new Student { Name="Omar", Grade=60 },
            new Student { Name="Sara", Grade=90 }
        };

            students.Sort()

            foreach (var s in students)
                Console.WriteLine(s.Name);
        }
    }
}
