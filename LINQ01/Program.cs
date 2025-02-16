using Demo;
using System.Diagnostics;
using System.Text.RegularExpressions;
using static Demo.ListGenerator;
namespace LINQ01
{
    class CaseInsensitiveComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators

            #region  1. Find all products that are out of stock.

            //var Result = ProductList.Where( P => P.UnitsInStock == 0 );

            //Result = from P in ProductList
            //         where P.UnitsInStock == 0
            //         select P;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.ProductName);
            //}

            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.

            //var Result = ProductList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3.00M);

            //Result = from P in ProductList
            //         where  P.UnitsInStock > 0 && P.UnitPrice > 3.00M
            //         select P;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.ProductName);
            //}

            #endregion

            #region 3. Returns digits whose name is shorter than their value.

            //String[] Arr = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result = Arr.Where( (str , Index) => str.Length < Index);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion


            #region LINQ - Ordering Operators

            #region  1. Sort a list of products by name.

            //var Result = ProductList.OrderBy(P => P.ProductName);

            //Result = from P in ProductList
            //         orderby P.ProductName
            //         select P;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result = Arr.OrderBy(Word => Word , new CaseInsensitiveComparer());

            ////can be : // var Result = Arr.OrderBy(Word => Word , StringComparer.OrdinalIgnoreCase);


            //foreach (var item in Arr)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 3. Sort a list of products by units in stock from highest to lowest.

            //var Result = ProductList.OrderByDescending(P => P.UnitsInStock);

            //Result = from P in ProductList
            //         orderby P.UnitsInStock descending
            //         select P;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result = Arr.OrderBy(Word => Word.Length).ThenBy(Word => Word);

            //Result = from word in Arr
            //         orderby word.Length, word
            //         select word;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.

            //String [] Arr = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};

            //var Result = Arr.OrderBy(Word => Word.Length).ThenBy(Word => Word , new CaseInsensitiveComparer());

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region  6. Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var Result = ProductList.OrderBy(P => P.Category).ThenByDescending(P => P.UnitPrice);

            //Result = from P in ProductList
            //         orderby P.Category, P.UnitPrice descending
            //         select P;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region  7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.

            //String [] Arr = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};

            //var Result = Arr.OrderBy(Word => Word.Length).ThenByDescending(Word => Word , new CaseInsensitiveComparer());

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //String [] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"}; 

            //var Result = Arr.Where(Word => Word[1] == 'i').Reverse();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion


            #region LINQ – Transformation Operators

            #region 1. Return a sequence of just the names of a list of products.

            //var Result = ProductList.Select(P => P.ProductName);

            //Result = from P in ProductList
            //         select P.ProductName;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).

            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var Result = words.Select(Word => new { Upper = Word.ToUpper(), Lower = Word.ToLower() });

            //Result = from Word in words
            //         select new { Upper = Word.ToUpper(), Lower = Word.ToLower() };

            //foreach (var item in Result)

            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 3.Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var Result = ProductList.Select(P => new { P.ProductName, Price = P.UnitPrice });

            //Result = from P in ProductList
            //         select new { P.ProductName, Price = P.UnitPrice };

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 4.Determine if the value of int in an array match their position in the array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Select((Value, Index) => new { Value, Index });

            //Console.WriteLine("Number: In-Place ?");
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item.Value}: {item.Value == item.Index}");
            //}

            #endregion

            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var Result = numbersA.SelectMany(A => numbersB, (A, B) => new { A, B }).Where( Pair => Pair.A < Pair.B);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item.A} is less than {item.B}");
            //}

            #endregion

            #region 6. Select all orders where the order total is less than 500.00.

            //var Result = CustomerList.SelectMany(C => C.Orders).Where(O => O.Total < 500.00M);

            //Result = from C in CustomerList
            //         from O in C.Orders
            //         where O.Total < 500.00M
            //         select O;
            //// Console.WriteLine(Result.Count());
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 7. Select all orders where the order was made in 1998 or later.

            //var Result = CustomerList.SelectMany(C => C.Orders).Where(O => O.OrderDate.Year >= 1998);

            //Result = from C in CustomerList
            //         from O in C.Orders
            //         where O.OrderDate.Year >= 1998
            //         select O;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion
        }
    }
}
