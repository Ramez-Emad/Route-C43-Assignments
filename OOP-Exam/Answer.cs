using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class Answer : IComparable<Answer> , ICloneable
    {
        public int Id { get; set; } = 0;
        public string Text { get; set; } = "" ;

        public Answer()
        {
        }
        public Answer( Answer answer)
        {
            Id = answer.Id;
            Text = answer.Text;
        }
        public object Clone()
        {
            return new Answer(this);    
        }

        // returns 0 if the two answers are equal,
        // 1 if the current answer is greater than the other,
        // -1 if the current answer is less than the other
        public int CompareTo(Answer? other)
        {
            if (other == null) return 1;

            if (Id == other.Id)
            {
                return Text.CompareTo(other.Text);
                // If Other.Text is null, the method returns 1.
                // The comparison will treat any non-null string as greater than null

            }
            return Id.CompareTo(other.Id);  
        }

        override public string ToString()
        {
            return $"{Id} - {Text}";
        }
    }
}
