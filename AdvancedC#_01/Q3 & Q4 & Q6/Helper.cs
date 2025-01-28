using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC__01.Q3
{
    internal class Helper
    {
        public static void ReverseArray(ArrayList list)
        {
            if(list is  null) return;
                          
            int left = 0, right = list.Count - 1;

            while (left < right)
            {
                object? temp = list[left];
                list[left] = list[right];
                list[right] = temp;

                left++;
                right--;
            }
        }

        public static List<int> GetEvenNumbers(List<int> list)
        {
            List<int> result = new List<int>();

            foreach (int i in list)
                if (i % 2 == 0)
                    result.Add(i);

            return result;
        }


        public static int FindFirstIndex(string input)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (result.ContainsKey(c))
                    result[c]++;
                else
                    result[c] = 1;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (result[input[i]] == 1)
                    return i;
            }

            return -1;
        }
    }
}
