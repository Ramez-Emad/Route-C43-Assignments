using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class Subject
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public Exam SubjectExam { get; set; } 

        public Subject(int _id, string _name)
        {
            Id = _id;
            Name = _name;
        }


        public void CreateExam()
        {

            int In;
            do
            {
                Console.WriteLine("Please Enter The type of Exam ( 1 for Practical , 2 For Final)");
            } while (!int.TryParse(Console.ReadLine(), out In) | In < 1 | In > 2);

            if (In == 1)
            {
                SubjectExam = new PracticalExam();
            }
            else
            {
                SubjectExam = new FinalExam();
            }
        }


        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }
}
