using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal abstract class Question 
    {
        public string Header { get; set; } = "";

        public string Body { get; set; } = "";

        public int Mark { get; set; }

        public Answer[] Answers { get; set; } = [];

        protected Answer? CorrectAnswer { get; set; }

        protected int NumberOfChoices {get; set;}

        abstract public void CreateQuestion();   


        public int ShowQuestionAndCalcMark()
        {
            Console.WriteLine($"{Header}        Mark : {Mark}");
            Console.WriteLine(Body);

            foreach (var answer in Answers)
            {
                Console.WriteLine($"{answer.Id} - {answer.Text}");
            }

            int In;
            do
            {
                Console.Write("Please Enter Your Answer : ");
            } while (!int.TryParse(Console.ReadLine(), out In) | In < 0 | In > NumberOfChoices);
            
            return Answers[In-1].CompareTo(CorrectAnswer) == 0 ? Mark : 0;
        }

        protected void GetBodyAndMarkFromUser()
        {
            Console.WriteLine(Header);

            Console.WriteLine("Please Enter The Body of Question:");
            Body = Console.ReadLine() ?? "";

            int InMark;
            do
            {
                Console.WriteLine("Please Enter The Marks of Question:");
            } while (!int.TryParse(Console.ReadLine(), out InMark));
            Mark = InMark;
        }

       
    }

}
