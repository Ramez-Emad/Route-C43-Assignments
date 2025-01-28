using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC__01.Q1
{
    internal static class SortHelper<T>  where T : IComparable<T>
    {
        public static void BubbleSort( T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                bool flag = false;

                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        T tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;

                        flag = true;
                    }
                }
                if (!flag)
                    break;
            }
        }


        private static void merge(T[] arr, int l, int m, int r) 
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            T[] L = new T[n1];
            T[] R = new T[n2];

            for (int i = 0; i < n1; i++)
            {
                L[i] = arr[l + i];
            }

            for (int j = 0; j < n2; j++)
            {
                R[j] = arr[m + 1 + j];
            }

            int k = l;
            int x = 0;
            int y = 0;

            while (x < n1 && y < n2)
            {
                if (L[x].CompareTo(R[y]) <= 0)
                {
                    arr[k] = L[x];
                    x++;
                }
                else
                {
                    arr[k] = R[y];
                    y++;
                }
                k++;
            }

            while (x < n1)
            {
                arr[k] = L[x];
                x++;
                k++;
            }

            while (y < n2)
            {
                arr[k] = R[y];
                y++;
                k++;
            }
        }
        public static void mergeSort(T[] arr, int l, int r) 
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                mergeSort(arr, l, m);
                mergeSort(arr, m + 1, r);
                merge(arr, l, m, r);
            }
        }
    }
}
