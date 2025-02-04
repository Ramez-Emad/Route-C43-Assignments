using System;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.NetworkInformation;
using System.Xml.Linq;
using System.Collections.Generic;

namespace AdvancedC__02
{
    internal class Program
    {
        static void Main()
        {
            #region Q1

            // 1. Given an array consists of numbers with size N and number of
            //    queries, in each query you will be given an integer X, and you should
            //    print how many numbers in array that is greater than X.


            //int size;
            //do
            //{
            //    Console.Write("Please enter the size of array : ");
            //} while (!int.TryParse(Console.ReadLine(), out size) || size < 1);

            //int numberOfQueries;

            //do
            //{
            //    Console.Write("Please enter the number of queries : ");
            //} while (!int.TryParse(Console.ReadLine(), out numberOfQueries) || numberOfQueries < 0);

            //List<int> numbers = new List<int>(size);

            //for (int i = 1; i <= size; i++)
            //{
            //    int number;
            //    do
            //    {
            //        Console.Write($"Please enter the number {i} : ");

            //    } while (!int.TryParse(Console.ReadLine(), out number));

            //    numbers.Add(number);
            //}


            //for (int i = 1; i <= numberOfQueries; i++)
            //{
            //    int query;
            //    do
            //    {
            //        Console.Write($"Please enter the query {i} : ");

            //    } while (!int.TryParse(Console.ReadLine(), out query));

            //    int count = numbers.Count(delegate (int a) { return a > query; });

            //    Console.WriteLine($"The number of elements greater than {query} is {count}");
            //}




            #endregion

            #region Q2

            // 2. Given a number N and an array of N numbers. Determine if it's palindrome or not.

            //int size;
            //do
            //{
            //    Console.Write("Please enter the size of array : ");
            //} while (!int.TryParse(Console.ReadLine(), out size) || size < 1);

            //List<int> numbers = new List<int>(size);

            //for (int i = 1; i <= (size+1) / 2; i++)
            //{
            //    int number;
            //    do
            //    {
            //        Console.Write($"Please enter the number {i} : ");

            //    } while (!int.TryParse(Console.ReadLine(), out number));

            //    numbers.Add(number);
            //}

            //bool flag = true;
            //for (int i = (size+1) / 2 + 1; i <= size; i++)
            //{
            //    int number;
            //    do
            //    {
            //        Console.Write($"Please enter the number {i} : ");

            //    } while (!int.TryParse(Console.ReadLine(), out number));

            //    if (number != numbers[ size - i ])
            //        flag = false;
            //}

            //if (flag)
            //    Console.WriteLine("The array is palindrome");
            //else
            //    Console.WriteLine("The array is not palindrome");

            #endregion

            #region Q3

            // 3. Given a Queue, implement a function to reverse the elements of a
            //    queue using a stack.

            //Queue<int> queue = new Queue<int>(6);
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //queue.Enqueue(6);

            //Console.WriteLine("The original queue is : ");

            //foreach (int item in queue)
            //{
            //    Console.Write($"{item} ");
            //}

            //Stack<int> stack = new Stack<int>();

            //while (queue.Count > 0)
            //{
            //    stack.Push(queue.Dequeue());
            //}

            //while (stack.Count > 0)
            //{
            //    queue.Enqueue(stack.Pop());
            //}

            //Console.WriteLine("");
            //Console.WriteLine("The reversed queue is : ");

            //foreach (int item in queue)
            //{
            //    Console.Write($"{item} ");
            //}


            #endregion

            #region Q4

            // Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.

            // [()]{}

            //string input = "[()]{}";

            //Dictionary<char, char> dictionary = new Dictionary<char, char>();
            //dictionary.Add('(', ')');
            //dictionary.Add('[', ']');
            //dictionary.Add('{', '}');

            //Stack<char> stack = new Stack<char>();

            //bool flag = true;

            //foreach (char item in input)
            //{
            //    if (item == '(' || item == '[' || item == '{')
            //    {
            //        stack.Push(item);
            //    }

            //    else if (item == ')' || item == ']' || item == '}')
            //    {
            //        if (stack.Count == 0)
            //        {
            //            flag = false;
            //            break;
            //        }

            //        char temp = stack.Pop();

            //        if (dictionary[temp] != item)
            //        {
            //            flag = false;
            //            break;
            //        }
            //    }

            //}

            //if (stack.Count == 0 && flag)
            //    Console.WriteLine("The string is balanced");
            //else
            //    Console.WriteLine("The string is not balanced");
            #endregion

            #region Q5

            // 5. Given an array, implement a function to remove duplicate elements from an array.

            //List<int> numbers = new List<int> { 1, 2, 7, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4 };

            //numbers = numbers.Distinct().ToList();

            //foreach (int item in numbers)
            //{
            //    Console.Write($"{item} ");
            //}

            #endregion

            #region Q6

            // 6. Given an array list , implement a function to remove all odd numbers from it.

            //List<int> numbers = new List<int> { 1, 2, 7, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4 };

            //numbers = numbers.Where(delegate (int a) { return (a % 2) == 0; }).ToList();

            //foreach (int item in numbers)
            //{
            //    Console.Write($"{item} ");
            //}

            #endregion

            #region Q7

            // Implement a queue that can hold different data types.
            //  And insert the following data:
            //  queue.Enqueue(1)
            //  queue.Enqueue(“Apple”)
            //  queue.Enqueue(5.28)

            //Queue<object> queue = new Queue<object>();
            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            //foreach (object item in queue)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Q8

            // 8. Create a function that pushes a series of integers onto a stack. Then,
            // search for a target integer in the stack.If the target is found, print a
            // message indicating that the target was found how many elements were
            // checked before finding the target(“Target was found successfully and
            // the count = 5”).If the target is not found, print a message indicating that
            // the target was not found(“Target was not found”).
            // Note : take the target as input from the user

            //Stack<int> stack = new Stack<int>();

            //for (int i = 1; i <= 10; i++)
            //{
            //    stack.Push(i);
            //}

            //Console.Write("Please enter the target : ");

            //int target;

            //do
            //{
            //    Console.Write("Please enter the target : ");
            //} while (!int.TryParse(Console.ReadLine(), out target));

            //int cnt = 0;

            //bool flag = false;

            //while (stack.Count > 0)
            //{
            //    cnt++;
            //    if (stack.Pop() == target)
            //    {
            //        flag = true;
            //        break;
            //    }
            //}

            //if (flag)
            //    Console.WriteLine($"Target was found successfully and the count = {cnt}");
            //else
            //    Console.WriteLine("Target was not found");

            #endregion

            #region Q9

            // 9. Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays.

            //List<int> numbers1 = new List<int> { 1, 2, 7, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4 };
            //List<int> numbers2 = new List<int> { 1, 2, 7, 3, 9, 1, 2, 3, 4 };

            //List<int> result = new List<int>();

            //foreach (int item in numbers1)
            //{
            //    if (numbers2.Contains(item))
            //    {
            //        result.Add(item);
            //        numbers2.Remove(item);
            //    }
            //}

            //foreach (int item in result)
            //{
            //    Console.Write($"{item} ");
            //}

            #endregion

            #region Q10

            // 10 .Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target.

            //List<int> numbers = new List<int> { 5, 2 , 3 , 7 , 5};

            //int target = 12;

            //int st = 0 , en = 0 ,sum = 0;


            //bool found = false; 

            //while (en <= numbers.Count && st<=en) 
            //{
            //    if (sum == target)
            //    {
            //        Console.WriteLine($"The sub list is from {st + 1} to {en}");
            //        found = true;
            //        break; 
            //    }

            //    if (sum < target  )
            //    {
            //        if (en < numbers.Count)
            //            sum += numbers[en];
            //        en++;
            //    }
            //    else 
            //    {
            //        if (st - 1 <= en )
            //            sum -= numbers[st];
            //        st++;
            //    }
            //}

            //if (!found)
            //{
            //    Console.WriteLine("No valid subarray found.");
            //}



            #endregion

            #region Q11

            // Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order

            //Queue<int> queue = new Queue<int>(6);

            //for (int i = 1; i <= 10 ; i++)
            //{
            //    queue.Enqueue(i);
            //}

            //int k = 4 ;

            //Stack<int> stack = new Stack<int>();

            //for (int i = 1; i <= k; i++)
            //{
            //    stack.Push(queue.Dequeue());
            //}

            //while (stack.Count > 0)
            //{
            //    queue.Enqueue(stack.Pop());
            //}

            //for (int i = 1; i <= queue.Count - k; i++)
            //{
            //    queue.Enqueue(queue.Dequeue());
            //}

            //foreach (int item in queue)
            //{
            //    Console.Write($"{item} ");
            //}


            #endregion
        }
    }
}
