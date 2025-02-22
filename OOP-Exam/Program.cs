using System.Diagnostics;

namespace OOP_Exam
{
    internal class Program
    {
        static void Main()
        {
            Subject Sub01 = new (1, "Math");
            Sub01.CreateExam();
            Console.Clear();

            Console.WriteLine("Do you want to start The exam [y | n ] :");

            if (char.Parse(Console.ReadLine()??"") == 'y')
            {
                Stopwatch sw = new ();
                sw.Start();
                Sub01.SubjectExam.ShowExam();

                Console.WriteLine($"The ELapsed Time is :  {sw.Elapsed}");
            }



        }
    }
}
