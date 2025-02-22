using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class MCQQuestion : Question
    {

        public MCQQuestion() : this(4)
        {
        }

        public MCQQuestion(int num)
        {
            Header = "MCQ - Question";
            NumberOfChoices = num;
            Answers = new Answer[NumberOfChoices];
        }

        public override void CreateQuestion()
        {
            GetBodyAndMarkFromUser();

            Console.WriteLine("The Choices Of Question:");

            for (int i = 0; i < NumberOfChoices; i++)
            {
                Console.WriteLine($"Please Enter The Choice Number {i+1}");
                Answers[i] = new Answer()
                {
                    Id = i+1,
                    Text = Console.ReadLine() ?? ""
                };
            }


            int InCorrect;
            do
            {
                Console.Write("Please Specify The Right Choice Of Question : ");
            } while (!int.TryParse(Console.ReadLine(), out InCorrect) | InCorrect < 1 | InCorrect > NumberOfChoices);

            CorrectAnswer = (Answer)Answers[InCorrect - 1].Clone();
        }
    }
}
