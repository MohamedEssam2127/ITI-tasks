namespace lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department d = new Department { DeptID = 101, DeptName = "Tech" };
            Club c = new Club { ClubID = 1, ClubName = "Gym" };

            Employee e = new Employee { EmployeeID = 1, BirthDate = new DateTime(1950, 1, 1), VacationStock = 5 };
            SalesPerson s = new SalesPerson { EmployeeID = 2, BirthDate = new DateTime(1950, 1, 1) , AchievedTarget = 20 ,VacationStock= 0 };
            BoardMember b = new BoardMember { EmployeeID = 3  , BirthDate = new DateTime(1950, 1, 1),  VacationStock = 0  };

            d.AddStaff(e); 
            d.AddStaff(s); 
            d.AddStaff(b);

            c.AddMember(e); 
            c.AddMember(s);
            c.AddMember(b);

            Console.WriteLine("Test 1:  Employee Vacation");
            e.RequestVacation(DateTime.Now, DateTime.Now.AddDays(10));
            s.RequestVacation(DateTime.Now, DateTime.Now.AddDays(10));
            b.RequestVacation(DateTime.Now, DateTime.Now.AddDays(10));


            Console.WriteLine("\n  Staff List:");
            d.ShowStaff();

            Console.WriteLine("\n    Member list List:");
            c.ShowMembers();

            Console.WriteLine("\n======================================");
            Console.WriteLine("\nTest 2:  Employee Age");
           
            e.EndOfYearOperation();
            //s.EndOfYearOperation(); 
            b.EndOfYearOperation();

            Console.WriteLine("\n Staff List:");
            d.ShowStaff();
            Console.WriteLine("\n  Member list List:");
            c.ShowMembers();
            Console.WriteLine("\n======================================");

            Console.WriteLine("\n Sales Target");
            s.CheckTarget(50);

            Console.WriteLine("\nTest 4: Board Resignation");
            b.Resign();

            Console.WriteLine("\nFinal Staff List:");
            d.ShowStaff();
            Console.WriteLine("\nFinal  Member list List:");
            c.ShowMembers();
        }
    }
}
