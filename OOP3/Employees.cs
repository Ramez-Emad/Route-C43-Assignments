namespace OOP3
{
    #region Gender Restriction
    enum Gender
    {
        Male = 1,
        Female
    }

    #endregion

    #region security privileges
    [Flags]
    enum SecuritPrivileges : byte
    {
        Guest = 1,
        Developer = 2,
        Secretary = 4,
        DBA = 8
    }

    #endregion


    public class Employee : IComparable
    {

        #region Attributes
        int id;
        string name;
        double salary;
        HirringDate hirringDate;
        Gender gender;
        SecuritPrivileges securityLevel;
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }
        public HirringDate HirringDate { get => hirringDate; set => hirringDate = value; }
        internal Gender Gender { get => gender; set => gender = value; }
        internal SecuritPrivileges SecurityLevel { get => securityLevel; set => securityLevel = value; }
        #endregion

        #region Constructor
        public Employee()
        {
            HirringDate = new HirringDate();
        }
        #endregion


        #region  override ToString()
      
        public override string ToString()
        {
            return $"ID: {Id} \nName: {Name} \nSecurityLevel: {SecurityLevel} \nGender: {Gender} \nSalary: {Salary:C} HirringDate: {HirringDate}";
        }
        #endregion

        #region Create Array
        public static Employee[] CreateEmployee(int size)
        {
            if (size > 0)
            {
                Employee[] employees = new Employee[size];
                for (int i = 0; i < size; i++)
                {
                    employees[i] = new Employee();
                }
                return employees;
            }
            throw new ArgumentException("Size Must Be Greater Than 0");
        }
        #endregion

        #region Insert Data Into Array
        public static void InsertData(Employee[] employee)
        {
            if (employee is not null)
            {
                for (int i = 0; i < employee.Length; i++)
                {
                    Console.WriteLine($"Enter Data For Employee number {i + 1}");
                    Console.WriteLine("------");

                    bool valid;
                    do
                    {
                        Console.Write("ID: ");
                        valid = int.TryParse(Console.ReadLine(), out employee[i].id);
                    } while (!valid);

                    do
                    {
                        Console.Write("Name: ");
                        employee[i].Name = Console.ReadLine();
                    } while (String.IsNullOrEmpty(employee[i].name));

                    do
                    {
                        Console.Write("Salary: ");
                        valid = double.TryParse(Console.ReadLine(), out employee[i].salary);
                    } while (!valid);

                    int gender1;
                    Console.WriteLine("1 For Male & 2 For Female");

                    do
                    {
                        Console.Write("Gender: ");
                        valid = int.TryParse(Console.ReadLine(), out gender1);
                    } while (!(valid && Enum.IsDefined(typeof(Gender), gender1)));
                    employee[i].Gender = (Gender)gender1;

                    Console.WriteLine("Hint: Guest=1 , Developer = 2 , Secretary = 4 , DBA = 8");
                    int sp;

                    do
                    {
                        Console.Write("Security Level: ");
                        valid = int.TryParse(Console.ReadLine(), out sp);
                    } while (!valid || !(sp > 0 && sp <= 15));
                    employee[i].SecurityLevel = (SecuritPrivileges)sp;

                    Console.WriteLine("Hire Date ");
                    int day, month, year;

                    do
                    {
                        Console.Write("Day: ");
                        valid = int.TryParse((Console.ReadLine()), out day);
                    } while (!valid || day > 31);
                    employee[i].HirringDate.Day = day;

                    do
                    {
                        Console.Write("Month: ");
                        valid = int.TryParse((Console.ReadLine()), out month);
                    } while (!valid | month > 12);
                    employee[i].HirringDate.Month = month;

                    do
                    {
                        Console.Write("Year: ");
                        valid = int.TryParse((Console.ReadLine()), out year);
                    } while (!valid  || year > DateTime.Now.Year);
                    employee[i].HirringDate.Year = year;

                }
            }
        }

        #endregion

        #region Print Array
        public static void Print(Employee[] empArr)
        {
            for (int i = 0; i < empArr.Length; i++)
            {
                Console.WriteLine($"Data For Employee Number {i + 1}");
                Console.WriteLine(empArr[i]);
                Console.WriteLine("====================================");

            }
        }

        #endregion

        #region Sort Array
        public static void SortArray(Employee[] empArr)
        {
            if (empArr is not null)
            {
                Array.Sort(empArr);
            }
        }

        public int CompareTo(object? obj)
        {
            Employee right = (Employee) obj ;

            if (HirringDate.Year > right.HirringDate.Year)
            {
                return -1;
            }
            else if (HirringDate.Year < right.HirringDate.Year)
            {
                return 1;
            }
            else
            {
                if (HirringDate.Month > right.HirringDate.Month)
                {
                    return -1;
                }
                else if (HirringDate.Month < right.HirringDate.Month)
                {
                    return 1;
                }
                else
                {
                    if (HirringDate.Day > right.HirringDate.Day)
                    {
                        return -1;
                    }
                    else if (HirringDate.Day < right.HirringDate.Day)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;

                    }
                }
            }
        }
        #endregion
    }
}
