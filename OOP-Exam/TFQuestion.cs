using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class TFQuestion : Question
    {
        public TFQuestion()
        {
            Header = "True | False Question";
            NumberOfChoices = 2;
            Answers =
            [
                new Answer {Id = 1 , Text = "True"},
                new Answer {Id = 2 , Text = "False"}
            ];
        }

        public override void CreateQuestion()
        {
            GetBodyAndMarkFromUser();

            int InCorrect;
            do
            {
                Console.WriteLine("Please Enter The Right Answer Of Question ( 1 for True and 2 for False) : ");

            } while (!int.TryParse(Console.ReadLine(), out InCorrect) | InCorrect < 1 | InCorrect > 2);
            CorrectAnswer =  (Answer) Answers[InCorrect - 1].Clone();
        }
    }
}
