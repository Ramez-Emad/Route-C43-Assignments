using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC__01.Q5
{
    public class FixedSizeList<T> 
    {
        public int Capacity { get; set; }
        public List<T> List { get; set; }

        public FixedSizeList(int _Capacity)
        {
            Capacity = _Capacity;
            List = new List<T>(Capacity);
        }

        public void Add(T item)
        {
            if (List.Count >= Capacity)
            {
                throw new InvalidOperationException("List Reached Max Capacity");
            }
            List.Add(item);
        }

        public T Get(int index)
        {
            if (index < 0 || index >= List.Count)
            {
                throw new InvalidOperationException("Index Out Of Range");
            }
            return List[index];
        }
    }
}
