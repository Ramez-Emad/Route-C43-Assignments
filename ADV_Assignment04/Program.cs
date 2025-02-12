namespace ADV_Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Emp = new Employee()
            {
                EmployeeID = 10,
                BirthDate = new DateTime(2002, 02, 12),
                VacationStock = 10
            };

            SalesPerson Sp = new SalesPerson()
            {
                EmployeeID = 20,
                BirthDate = new DateTime(2000, 12, 15),
                VacationStock = 15,
                AchievedTarget = 1000
            };
            BoardMember Bmp = new BoardMember()
            {
                EmployeeID = 30,
                BirthDate = new DateTime(1970, 5, 23),
                VacationStock = 20,
            };

            Department Dept = new Department()
            {
                DeptID = 1,
                DeptName = "Backend"
            };

            Club club = new Club()
            {
                ClubID = 1,
                ClubName = "Wadi Degla"
            };

            Dept.AddStaff(Emp);
            club.AddMember(Emp);
            Dept.AddStaff(Sp);
            club.AddMember(Sp);
            Dept.AddStaff(Bmp);
            club.AddMember(Bmp);


            Emp.VacationStock -= 20;
            Console.WriteLine();
            Console.WriteLine();

            Sp.CheckTarget(400);
            Console.WriteLine();
            Console.WriteLine();

            Bmp.Resign();

        }
    }
}
