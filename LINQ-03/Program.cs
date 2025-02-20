namespace LINQ_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Partitioning Operators

            #region 1. Get the first 3 orders from customers in Washington

            //var Result = CustomerList.Where(c => c.Country == "Washington")
            //                         .SelectMany(c => c.Orders)
            //                         .Take(3);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 2. Get all but the first 2 orders from customers in Washington.

            //var Result = CustomerList.Where(c => c.Country == "Washington").
            //                                      SelectMany(c => c.Orders).
            //                                      Skip(2);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.TakeWhile((n, index) => n >= index);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 4.Get the elements of the array starting from the first element divisible by 3.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.SkipWhile(n => n % 3 != 0);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 5. Get the elements of the array starting from the first element less than its position.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.SkipWhile((n, index) => n >= index);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

            #region Grouping Operators

            #region 1. Use group by to partition a list of numbers by their remainder when divided by 5

            // List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var Result = numbers.GroupBy(num => num % 5);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Remainder {item.Key}");
            //    foreach (var num in item)
            //        Console.WriteLine(num);

            //    Console.WriteLine();
            //}

            #endregion

            #region 2. Uses group by to partition a list of words by their first letter.Use dictionary_english.txt for Input

            //string[] lines = File.ReadAllLines("dictionary_english.txt");

            ////lines = lines.Take(100).ToArray();
            //var Result = lines.GroupBy(l => l[0]);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Words that start with {item.Key}");
            //    foreach (var word in item)
            //        Console.WriteLine(word);

            //    Console.WriteLine("---------------------------------");
            //}

            #endregion

            #region Use Group By with a custom comparer that matches words that are consists of the same Characters Together

            // String[] Arr = { "from", "salt", "earn", "last", "near", "form" };

            //var Result = Arr.GroupBy(w => w, new CustomComparer());

            //foreach (var item in Result)
            //{
            //    foreach (var word in item)
            //        Console.WriteLine(word);

            //    Console.WriteLine("---------------------------------");
            //}


            #endregion

            #endregion
        }
    }
}
