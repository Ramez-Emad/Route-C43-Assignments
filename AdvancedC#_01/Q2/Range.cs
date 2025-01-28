using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC__01.Q2
{
    internal class Range<T> where T : IComparable<T>
    {
        public T Max { get; set; }
        public T Min { get; set; }

        public Range(T _min, T _max)
        {
            Max = _max;
            Min = _min;
        }

        public bool IsInRange(T item)
        {
            return item.CompareTo(Min) >= 0 && item.CompareTo(Max) <= 0;
        }

        public T Length()
        {
            dynamic X = Max;
            dynamic Y = Min;

            return X - Y + 1;
        }

    }
}
