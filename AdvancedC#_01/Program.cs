using AdvancedC__01.Q1;
using AdvancedC__01.Q2;
using AdvancedC__01.Q3;
using AdvancedC__01.Q5;
using System.Collections;
namespace AdvancedC__01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //int[] arr = { 12, 11, 13, 5, 6, 7 };
            //Console.WriteLine("Given array is");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            //SortHelper<int>.mergeSort(arr, 0, arr.Length - 1);
            //SortHelper<int>.BubbleSort(arr);

            //Console.WriteLine("\n\nSorted array is");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            #endregion

            #region Q2

            //Range<int> range = new Range<int>(5, 10);

            //Console.WriteLine($" 8 {(range.IsInRange(8) ? "In range" : "Not in range") }");
            //Console.WriteLine($" 26 {(range.IsInRange(26) ? "In range" : "Not in range")}");

            //Console.WriteLine($"Length = {range.Length()}");

            #endregion

            #region Q3

            //ArrayList list = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Console.WriteLine("Array Before Reverse: ");

            //foreach (var i in list)
            //    Console.Write($"{i} ");

            //Helper.ReverseArray(list);

            //Console.WriteLine("\nArray After Reverse: ");

            //foreach (var i in list)
            //    Console.Write($"{i} ");

            #endregion

            #region Q4

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //List<int> EvenNumbers = Helper.GetEvenNumbers(Numbers);

            //Console.WriteLine("Even Numbers");
            //foreach (int number in EvenNumbers)
            //    Console.Write(number + " ");

            #endregion

            #region Q5

            //FixedSizeList<int> list = new FixedSizeList<int>(3);

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);

            //for (int i = 0; i < list.Capacity; i++)
            //{
            //    Console.WriteLine(list.Get(i));
            //}

            ////list.Add(4);

            //Console.WriteLine(list.Get(2));
            ////Console.WriteLine(list.Get(3));

            //Console.WriteLine("-------------------");
            #endregion

            #region Q6

            //string str = "RRaamez";

            //int Index = Helper.FindFirstIndex(str);


            //if (Index != -1)
            //    Console.WriteLine($"First NonRepeated Char = {str[Index]}");
            //else
            //    Console.WriteLine("All Char Are Repeated");

            #endregion
        }
    }
}
