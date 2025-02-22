using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class FinalExam : Exam
    {

        public FinalExam() 
        {
            CreateListOfQuestions();
        }
        protected override void CreateListOfQuestions()
        {
            for (int i = 0; i < NumberOfQuestion; i++)
            {
                Console.Clear();

                int In;
                do
                {
                    Console.WriteLine($"Please choose the type of Question ({i + 1}) (1 for TF , 2 for MCQ)");

                } while (!int.TryParse(Console.ReadLine(), out In) | In < 1 | In > 2);

                Console.WriteLine($"Question Number {i + 1}");

                if (In == 1)
                {
                    Questions[i] = new TFQuestion();
                }
                else
                {
                    Questions[i] = new MCQQuestion();
                }

                Questions[i].CreateQuestion();

            }
        }

    }
}
