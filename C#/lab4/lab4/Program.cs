namespace Lab4
{
    /// <summary>
    /// Represents an Employee with an id, security level, salary, hire date, and gender.
    /// </summary>
    struct Employee
    {
        int id;
        SECURITY securityLevel;
        double salary;
        HiringDate hireDate;
        Gender gender;
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id {
            get { return id; }
            set {
                id = value;
            }
        }
        public SECURITY SecurityLevel { 
               get { return securityLevel; }
               set { securityLevel = value; }

        }
        public double Salary { 
            get { return salary; }
            set {
                if (value >= 0) salary = value;
                else
                {
                    Console.WriteLine("Invalid salary");
                    salary = 0;
                }

            }
        }

        public HiringDate HireDate { 
             get { return hireDate; }
             set { hireDate = value;  }
        }
        public Gender MyGender { 
             get { return gender; }
            set { gender = value;  }
        }
        public Employee(int _id, SECURITY _s, double _salary, HiringDate h, Gender g ,string _name)
        {
            id = _id;
            securityLevel = _s;
            Salary =  _salary ;
            hireDate = h;
            gender = g;
            Name = _name;
        }
        public Employee()
        {
            id = 0;
            securityLevel = SECURITY.guest;
            salary = 0;
            hireDate = new HiringDate();
            gender = Gender.M;
            Name = "Guest  ";
        }

        public override string ToString()
        {
            SECURITY full = SECURITY.guest | SECURITY.secretary | SECURITY.Developer | SECURITY.DBA;
            string security;
            if (securityLevel == full)
                security = " full permissions";
            else
                security = securityLevel.ToString();


            return String.Format(
                 "ID: {0}\nSecurity: {1}\nSalary: {2:C}\nHire Date: {3}\nGender: {4} \n  name :{5} ",
                 id,
                 security,
                 salary,
                 hireDate,
                 gender,
                 name 
             );
        }

    }
    /// <summary>
    /// Represents the hiring date structure  of Day, Month, and Year.
    /// </summary>
    struct HiringDate 
    {
        int day;
        int month;
        int year;

        public HiringDate(int _day, int _month, int _year)
        {
            Day  = _day;
            Month =   _month;
            Year = _year;

        }
        public HiringDate()
        {
            DateTime today = DateTime.Today;
            day = today.Day;
            month = today.Month;
            year = today.Year;
        }
        public int Day {

            get { return day; }
            set {
                if (value > 0 && value < 32)
                {
                    day = value;
                }
                else
                {
                    Console.WriteLine("Invalid day ");
                }
            }
        }
        public int Month { 
          
            get { return month; }
            set
            {
                if (value > 0 && value <= 12)
                {
                    month =value;
                }
                else
                {
                    Console.WriteLine("Invalid month ");
                }
            }
          
        }

         public int Year { 
              get { return year; }
            set
            {
                if (value > 1950 && value <= 2026)
                {
                    year = value;
                }
                else
                {
                    Console.WriteLine("Invalid year ");
                }
            }
          
          }
        
        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }
    }

    /// <summary>
    /// Defines the gender of an employee.
    /// </summary>
    enum Gender
    {
        /// <summary>male</summary>
        M,
        /// <summaryfemale</summary>
        F
    }
    [Flags]
    /// <summary>
    /// Represents security levels using a byte-based bitwise flag.
    /// </summary>
    enum SECURITY : byte
    {
        /// <summary>Basic access level</summary>
        guest = 0b_0000_0001,
        /// <summary>Developer access level</summary>
        Developer = 0b_0000_0010,
        /// <summary>Secretary access level</summary>
        secretary = 0b_0000_0100,
        /// <summary>Database Administrator access level</summary>
        DBA = 0b_0000_1000
    }

    class EmployeeSearch {
        int[] NationalIDs;
        Employee[] Employees;

        public EmployeeSearch(Employee[] emps)
        {
            SortById(emps);

            Employees = emps;

            NationalIDs = new int[emps.Length];

            for (int i = 0; i < emps.Length; i++)
            {
                NationalIDs[i] = emps[i].Id;
            }
        }

        void SortById(Employee[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].Id > arr[j + 1].Id)
                    {
                        Employee temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public Employee this[int id]
        {
            get {
                int left = 0;
                int right  =  NationalIDs.Length-1;

                while (left <= right) {
                    int mid = (left + right) / 2;

                    if (NationalIDs[mid] == id)
                        return Employees[mid];

                    if (NationalIDs[mid] < id)
                        left = mid + 1;
                    else
                        right = mid - 1;
                }
                return   new Employee(-1,
                    SECURITY.guest, 
                    0, new HiringDate(),
                    Gender.M, "Not Found");
            }
        }


        public Employee[] this[string name]
        {
            get
            {
    
                int count = 0;
                for (int i = 0; i < Employees.Length; i++)
                {
                    if (Employees[i].Name.ToLower() == name.ToLower())
                        count++;
                }

                if (count == 0)
                {
                    return new Employee[] { new Employee(-1, SECURITY.guest, 0, new HiringDate(), Gender.M, "Not Found") };
                }

               
                Employee[] result = new Employee[count];
                int index = 0;
                for (int i = 0; i < Employees.Length; i++)
                {
                    if (Employees[i].Name.ToLower() == name.ToLower())
                    {
                        result[index] = Employees[i];
                        index++;
                    }
                }

                return result;
            }
        }

        public Employee[] this[HiringDate date]
        {
            get
            {
                
                int count = 0;
                for (int i = 0; i < Employees.Length; i++)
                {
                    if (Employees[i].HireDate.Day == date.Day &&
                        Employees[i].HireDate.Month == date.Month &&
                        Employees[i].HireDate.Year == date.Year)
                    {
                        count++;
                    }
                }

                if (count == 0)
                {
                    return new Employee[] { new Employee(-1, SECURITY.guest, 0, new HiringDate(), Gender.M, "Not Found") };
                }

               
                Employee[] result = new Employee[count];
                int index = 0;
                for (int i = 0; i < Employees.Length; i++)
                {
                    if (Employees[i].HireDate.Day == date.Day &&
                        Employees[i].HireDate.Month == date.Month &&
                        Employees[i].HireDate.Year == date.Year)
                    {
                        result[index] = Employees[i];
                        index++;
                    }
                }

                return result;
            }
        }
    }

    internal class Program
    {

        static void sortByHireDate(Employee[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (IsLaterDate(arr[j].HireDate, arr[j + 1].HireDate))
                    {
                        Employee temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static bool IsLaterDate(HiringDate d1, HiringDate d2)
        {
            if (d1.Year > d2.Year) return true;
            if (d1.Year < d2.Year) return false;

            if (d1.Month > d2.Month) return true;
            if (d1.Month < d2.Month) return false;

            return d1.Day > d2.Day;
        }

        static void PrintArray(Employee[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                Console.WriteLine("---------------------");
            }
        }
        static void Main(string[] args)
        {
            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee(1, 
                SECURITY.DBA, 15_000,
                new HiringDate(1, 1, 2020),
                Gender.M ,
                "usf"
            );

            EmpArr[1] = new Employee(2, SECURITY.guest, 5_000,
                 new HiringDate(1, 1, 2025),
                Gender.F , "sara"
            );
            EmpArr[2] = new Employee(
                3,
                SECURITY.guest | SECURITY.Developer | SECURITY.secretary | SECURITY.DBA,
                20_000,
                new HiringDate(3, 3, 2019),
                Gender.M ,
                "MOhamed"
            );



            #region  input  
            //for (int i = 0; i < 1; i++)
            //{
            //    Console.WriteLine($"Enter Employee {i + 1}");

            //    Employee emp = new Employee();

            //    int id;
            //    Console.Write("ID: ");
            //    while (!int.TryParse(Console.ReadLine(), out id))
            //    {
            //        Console.Write("Invalid ID: ");
            //    }


            //    Console.Write("name  : ");
            //    emp.Name= Console.ReadLine();


            //    emp.Id = id ;
            //    double salary;
            //    Console.Write("Salary: ");
            //    while (!double.TryParse(Console.ReadLine(), out salary) || salary <= 0)
            //    {
            //        Console.Write("Invalid Salary: ");
            //    }
            //    emp.Salary = salary ;

            //    string gInput;
            //    Gender g;

            //    while (true)
            //    {
            //        Console.Write("Gender (M/F): ");
            //        gInput = Console.ReadLine().ToUpper();

            //        if (Enum.IsDefined(typeof(Gender), gInput))
            //        {
            //            g = (Gender)Enum.Parse(typeof(Gender), gInput);
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("invalid Gender");
            //        }
            //    }

            //    emp.MyGender = g ;


            //    SECURITY sec = SECURITY.guest;

            //    bool validsec = false;
            //    while (!validsec)
            //    {
            //        Console.WriteLine("Enter Security ( { G }  for guest    , { D } for Developer  , \n  " +
            //            "{ S } secretary   ,  {A} DBA) OR write  { F }'full permissions':");

            //        string input = Console.ReadLine().ToLower();

            //        switch (input)
            //        {
            //            case "g":
            //                sec = SECURITY.guest;
            //                validsec = true;
            //                break;
            //            case "d":
            //                sec = SECURITY.Developer;
            //                validsec = true;
            //                break;
            //            case "s":
            //                sec = SECURITY.secretary;
            //                validsec = true;
            //                break;

            //            case "a":
            //                sec = SECURITY.DBA;
            //                validsec = true;
            //                break;

            //            case "f":
            //                sec = SECURITY.guest | SECURITY.Developer | SECURITY.secretary | SECURITY.DBA;
            //                validsec = true;
            //                break;
            //            default:
            //                Console.WriteLine("invalid  security level ");
            //                break;
            //        }



            //    }

            //    emp.SecurityLevel = sec;

            //    HiringDate hd = new HiringDate();

            //    int day, month, year;

            //    Console.Write("Day: ");
            //    while (!int.TryParse(Console.ReadLine(), out day))
            //    {
            //        Console.Write("Invalid Day: ");
            //    }
            //    hd.Day = day;

            //    Console.Write("Month: ");
            //    while (!int.TryParse(Console.ReadLine(), out month))
            //    {
            //        Console.Write("Invalid Month: ");
            //    }
            //    hd.Month = month ;

            //    Console.Write("Year: ");
            //    while (!int.TryParse(Console.ReadLine(), out year))
            //    {
            //        Console.Write("Invalid Year: ");
            //    }
            //    hd.Year= year;
            //    emp.HireDate = hd ;
            //    EmpArr[i] = emp;
            //}
            #endregion





            //Console.WriteLine("---------------------");
            //for (int i = 0; i < EmpArr.Length; i++)
            //{
            //    Console.WriteLine(EmpArr[i]);
            //    Console.WriteLine("---------------------");
            //}


            Console.WriteLine("------------ BEFORE SORTING ------------");
            PrintArray(EmpArr);

            sortByHireDate(EmpArr);

            Console.WriteLine("\n------------ AFTER SORTING ------------");
            PrintArray(EmpArr);


            //EmployeeSearch search = new EmployeeSearch(EmpArr);

            //Console.WriteLine("search[-1]");
            //Console.WriteLine(search[-1]);
            //Console.WriteLine("---------------------");
            //Console.WriteLine("search[2]");
            //Console.WriteLine(search[2]);
            //Console.WriteLine("---------------------");
            //Console.WriteLine("search[ sara ]");
            
            //var employeesByName = search["sara"];
            //foreach (var e in employeesByName)
            //{
            //    Console.WriteLine(e);
            //    Console.WriteLine("---------------------");
            //}
            //Console.WriteLine("search[1/1/2020]");
            //var employeesByDate = search[new HiringDate(1, 1, 2020)];
            //foreach (var e in employeesByDate)
            //{
            //    Console.WriteLine(e);
            //    Console.WriteLine("---------------------");
            //}

        }


    }

}
