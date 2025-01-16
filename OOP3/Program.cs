namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = Employee.CreateEmployee(3);

            Employee.InsertData(employees);

            Console.Clear();

            Employee.Print(employees);

            Console.WriteLine("After Sorting");

            Employee.SortArray(employees);
            Employee.Print(employees);
        }
    }
}
