using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class PracticalExam : Exam
    {

        public PracticalExam()
        {
            CreateListOfQuestions();
        }
        protected override void CreateListOfQuestions()
        {
            for (int i = 0; i < NumberOfQuestion; i++)
            {
                Console.Clear();
                Console.WriteLine($"Question Number {i + 1}");
                Questions[i] = new MCQQuestion();
                Questions[i].CreateQuestion();
            }
        }
    }
}
