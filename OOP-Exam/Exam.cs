using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal abstract class Exam
    {
        public Exam()
        {
            PrepareExam();
            Questions = new Question[NumberOfQuestion];
        }
        public int TimeOfExam { get; set; }

        public int NumberOfQuestion { get; set; }

        public Question[] Questions = []; // syntax sugar for new Question[0]

        protected abstract void CreateListOfQuestions();

        public void ShowExam()
        {
            Console.Clear();
            Console.WriteLine("Practical Exam has been started");
            Console.WriteLine($"Time of Exam : {TimeOfExam} Minutes");
            Console.WriteLine($"Number of Questions : {NumberOfQuestion}");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();

            int TotalMark = 0;
            int Grade = 0;
            foreach (var question in Questions)
            {

                Grade += question.ShowQuestionAndCalcMark();
                Console.WriteLine("-------------------");
                TotalMark += question.Mark;
            }

            Console.WriteLine($"Total Mark : {TotalMark}");
            Console.WriteLine($"Grade : {Grade}");

        }

        private void PrepareExam()
        {
            int In;
            do
            {
                Console.Write("Please Enter The Time Of Exam In Minutes : ");
            } while (!int.TryParse(Console.ReadLine(), out In) | In < 1);

            TimeOfExam = In;

            do
            {
                Console.Write("Please Enter The Number Of Questions You Wanted To Create : ");
            } while (!int.TryParse(Console.ReadLine(), out In) | In < 1);

            NumberOfQuestion = In;
        }
    }
    
}
