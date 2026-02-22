namespace Lab3
{

    struct Employee { 
          int id ;
         SECURITY securityLevel;
         double salary;
         HiringDate hireDate;
         Gender gender;


        public void SetId(int _id) { id = _id; }
        public void SetSecurityLevel(SECURITY s) { securityLevel = s; }
        public void SetSalary(double s)
        {
            if (s > 0 ) salary = s;
            else {
                Console.WriteLine("Invalid salary");
                salary = 0; 
            } 
        }
        public void SetHireDate(HiringDate h) { hireDate = h; }
        public void SetGender(Gender g) { gender = g; }

        public int GetId() { return id; }
        public SECURITY GetSecurityLevel() { return securityLevel; }
        public double GetSalary() { return salary; }
        public HiringDate GetHireDate() { return hireDate; }
        public Gender GetGender() { return gender; }



        public Employee(int _id  , SECURITY  _s , double _salary ,HiringDate h ,Gender g ) { 
               id  = _id ;
            securityLevel = _s ;
            SetSalary(_salary);
            hireDate = h ;
            gender = g ;
        }
        public Employee() {
            id = 0;
            securityLevel = SECURITY.guest;
            salary = 0 ;
            hireDate = new HiringDate();
            gender = Gender.M;
        }




        public override string ToString()
        {
            SECURITY full = SECURITY.guest | SECURITY.secretary | SECURITY.Developer | SECURITY.DBA;
            string security;
            if (securityLevel ==full)
                security = " full permissions";
            else
                security = securityLevel.ToString();


                return String.Format(
                     "ID: {0}\nSecurity: {1}\nSalary: {2:C}\nHire Date: {3}\nGender: {4}",
                     id,
                     security,
                     salary,
                     hireDate,
                     gender
                 );
        }
    
    }

    struct HiringDate {
          int day;
          int month;
          int year;

        public HiringDate(int _day,int _month,int _year)
        {
            setDay(_day);
            setmonth(_month);
            setYear(_year);

        }
        public HiringDate()
        {
            DateTime today = DateTime.Today;
            day = today.Day;
            month = today.Month;
            year = today.Year;
        }
        public bool IsLaterThan(HiringDate other)
        {
            if (year != other.year) return year > other.year;
            if (month != other.month) return month > other.month;
            return day > other.day;
        }
        public void setDay(int _day ) {
            if (_day > 0 && _day < 32)
            {
                day = _day;
            }
            else {
                Console.WriteLine("Invalid day ");
            }
        }
        public void setmonth(int _month)
        {
            if (_month > 0 && _month <=  12)
            {
                month = _month;
            }
            else
            {
                Console.WriteLine("Invalid month ");
            }
        }
        public void setYear(int _year  ) {
            if (_year > 1950 && _year <= 2026)
            {
                year = _year;
            }
            else
            {
                Console.WriteLine("Invalid year ");
            }
        }
        public int getDay() { return day; }
        public int getMonth() { return month; }
        public int getYear() { return year; }
        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }
    }
    enum Gender
    {
        M,
        F
    }
    [Flags]
    //guest, Developer, secretary and DBA.
    enum SECURITY  :byte{
        guest= 0b_0000_0001, Developer = 0b_0000_0010, secretary= 0b_0000_0100, DBA = 0b_0000_1000
    }

    internal class Program
    {
            static void Main(string[] args)
            {
                Employee[] EmpArr = new Employee[3];

                EmpArr[0] = new Employee(  1, SECURITY.DBA,15_000,
                       new HiringDate(1, 1, 2020),
                    Gender.M
                );

                EmpArr[1] = new Employee(2,SECURITY.guest,5_000,
                     new HiringDate(2, 2, 2022),
                    Gender.F
                );
                EmpArr[2] = new Employee(
                    3,
                    SECURITY.guest | SECURITY.Developer | SECURITY.secretary | SECURITY.DBA,
                    20_000,
                    new HiringDate(3, 3, 2019),
                    Gender.M
                );




            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine($"Enter Employee {i + 1}");

                Employee emp = new Employee();

                int id;
                Console.Write("ID: ");
                while (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.Write("Invalid ID: ");
                }

                emp.SetId(id);
                double salary;
                Console.Write("Salary: ");
                while (!double.TryParse(Console.ReadLine(), out salary) || salary <= 0)
                {
                    Console.Write("Invalid Salary: ");
                }
                emp.SetSalary(salary);

                string gInput;
                Gender g;

                while (true)
                {
                    Console.Write("Gender (M/F): ");
                    gInput = Console.ReadLine().ToUpper();

                    if (Enum.IsDefined(typeof(Gender), gInput))
                    {
                        g = (Gender)Enum.Parse(typeof(Gender), gInput);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("invalid Gender");
                    }
                }

                emp.SetGender(g);


                SECURITY sec = SECURITY.guest;
                
                bool validsec = false;
                while (!validsec )
                {
                    Console.WriteLine("Enter Security ( { G }  for guest    , { D } for Developer  , \n  " +
                        "{ S } secretary   ,  {A} DBA) OR write  { F }'full permissions':");

                    string input = Console.ReadLine().ToLower();

                    switch (input) {
                        case "g": 
                            sec = SECURITY.guest;
                            validsec = true;
                            break;
                        case "d":
                            sec = SECURITY.Developer;
                            validsec = true;
                            break;
                        case "s":
                            sec = SECURITY.secretary;
                            validsec = true;
                            break;

                        case "a":
                            sec = SECURITY.DBA;
                            validsec = true;
                            break;

                        case "f":
                            sec = SECURITY.guest | SECURITY.Developer | SECURITY.secretary | SECURITY.DBA;
                            validsec = true;
                            break;
                        default:
                            Console.WriteLine("invalid  security level ");
                            break; 
                    }

                   
                  
                }

                emp.SetSecurityLevel(sec);

                HiringDate hd = new HiringDate();

                int day, month, year;

                Console.Write("Day: ");
                while (!int.TryParse(Console.ReadLine(), out day))
                {
                    Console.Write("Invalid Day: ");
                }
                hd.setDay(day);

                Console.Write("Month: ");
                while (!int.TryParse(Console.ReadLine(), out month))
                {
                    Console.Write("Invalid Month: ");
                }
                hd.setmonth(month);

                Console.Write("Year: ");
                while (!int.TryParse(Console.ReadLine(), out year))
                {
                    Console.Write("Invalid Year: ");
                }
                hd.setYear(year);

                emp.SetHireDate(hd);

                EmpArr[i] = emp;
            }




            



            Console.WriteLine("---------------------"); 
            for (int i = 0; i <EmpArr.Length; i++)
            {
                Console.WriteLine(EmpArr[i]);
                Console.WriteLine("---------------------");
            }


        }


    }
    
}
