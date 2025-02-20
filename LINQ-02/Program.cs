using Demo;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Runtime.Intrinsics.X86;
using static Demo.ListGenerator;
using static System.Net.Mime.MediaTypeNames;

namespace LINQ_02
{
    // matches words that are consists of the same Characters Together
    class CustomComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return x.OrderBy(c => c).SequenceEqual(y.OrderBy(c => c));
        }

        public int GetHashCode(string obj)
        {
            return string.Concat(obj.OrderBy(c => c)).GetHashCode();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Element Operators

            #region 1. Get first Product out of Stock

            //var Result = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);

            //Console.WriteLine($"First Producy Out Of Stock is \n --- {Result}");

            #endregion

            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var Result = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(Result is null ? "Null" : Result);

            #endregion

            #region 3. Retrieve the second number greater than 5

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.Where( num => num > 5).ElementAtOrDefault(1);

            //Console.WriteLine(Result > 0 ?  Result : "No Element Found");

            #endregion

            #endregion

            #region Aggregate Operators

            #region 1. Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result  =  Arr.Count(Arr => Arr % 2 == 1);

            //Console.WriteLine($"Number of odd numbers is {Result}");

            #endregion

            #region 2. Return a list of customers and how many orders each has.

            //var Result = CustomerList.Select(C => new {C.CustomerName , NumberOfOrder = C.Orders.Count()});

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item.CustomerName} -> has {item.NumberOfOrder} Orders");
            //}

            #endregion

            #region 3. Return a list of categories and how many products each has

            //var Result = ProductList.GroupBy(p => p.Category).
            //                         Select(g => new { Category = g.Key, NumberOfProducts = g.Count() });

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item.Category} -> has {item.NumberOfProducts} Products");
            //}

            #endregion

            #region 4. Get the total of the numbers in an array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Sum();

            //Console.WriteLine($"Total of the numbers is {Result}");

            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] lines = File.ReadAllLines("dictionary_english.txt");

            //var Result = lines.Sum(l => l.Length);

            //Console.WriteLine($"Total number of characters of all words is {Result}");

            #endregion
            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] lines = File.ReadAllLines("dictionary_english.txt");

            //var Result = lines.Min(l => l.Length);

            //Console.WriteLine($"Length of the shortest word is {Result}");

            #endregion
            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] lines = File.ReadAllLines("dictionary_english.txt");

            //var Result = lines.Max(l => l.Length);

            //Console.WriteLine($"Length of the longest word is {Result}");

            #endregion
            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] lines = File.ReadAllLines("dictionary_english.txt");

            //var Result = lines.Average(l => l.Length);

            //Console.WriteLine($"Average length of the words is {Result}");

            #endregion

            #region 9. Get the total units in stock for each product category.

            //var Result = ProductList.Where(P => P.UnitsInStock > 0).
            //                         GroupBy(p => p.Category).
            //                         Select(g => new {
            //                                         Category = g.Key,
            //                                         TotalUnitsInStock = g.Sum(p => p.UnitsInStock) 
            //                                         }
            //                                );

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item.Category} -> has {item.TotalUnitsInStock} Units In Stock");
            //}

            #endregion

            #region 10. Get the cheapest price among each category's products

            //var result = ProductList
            //           .GroupBy(p => p.Category)
            //           .Select(g => new
            //           {
            //               Category = g.Key,
            //               CheapestPrice = g.Min(p => p.UnitPrice)
            //           });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category} -> has {item.CheapestPrice} Cheapest Price");
            //}



            #endregion

            #region 11. Get the products with the cheapest price in each category (Use Let)

            //var result = from p in ProductList
            //             group p by p.Category 
            //             into g
            //             let minPrice = g.Min(p => p.UnitPrice)
            //             select new {   Category = g.Key,
            //                            CheapestProducts = g.Where(p => p.UnitPrice == minPrice) 
            //                        };

            //foreach (var item in result)
            //{
            //    foreach (var product in item.CheapestProducts)
            //        Console.WriteLine($"{item.Category} -> has {product.ProductName}");
            //}

            #endregion

            #region 12. Get the most expensive price among each category's products.

            //var result = from p in ProductList
            //             group p by p.Category
            //             into g
            //             select new
            //             {
            //                 Category = g.Key,
            //                 MostMexpensivePrice = g.Max(p => p.UnitPrice)
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category} -> Most Expensive Price  {item.MostMexpensivePrice}");
            //}

            #endregion

            #region 13. Get the products with the most expensive price in each category.

            //var result = from p in ProductList
            //             group p by p.Category
            //             into g
            //             let maxPrice = g.Max(p => p.UnitPrice)
            //             select new
            //             {
            //                 Category = g.Key,
            //                 CheapestProducts = g.Where(p => p.UnitPrice == maxPrice)
            //             };

            //foreach (var item in result)
            //{
            //    foreach (var product in item.CheapestProducts)
            //        Console.WriteLine($"{item.Category} -> {product.ProductName}");
            //}

            #endregion

            #region 14. Get the average price of each category's products.

            //var result = from p in ProductList
            //             group p by p.Category
            //             into g
            //             select new
            //             {
            //                 Category = g.Key,
            //                 AveragePrice = g.Average(p => p.UnitPrice)
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category} -> Average Price  {item.AveragePrice}");
            //}

            #endregion

            #endregion

            #region Set Operators

            #region 1. Find the unique Category names from Product List

            //var Result = ProductList.DistinctBy(p => p.Category);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.Category);
            //}

            #endregion

            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.

            //var Result = ProductList.Select(p => p.ProductName[0])
            //                        .Union(CustomerList.Select(c => c.CustomerName[0]))
            //                        .Distinct();

            //foreach (var item in Result)
            //    Console.WriteLine(item);


            #endregion

            #region 3. Create one sequence that contains the common first letter from both product and customer names.

            //var Result = ProductList.Select(p => p.ProductName[0])
            //            .Intersect(CustomerList.Select(c => c.CustomerName[0]));


            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names

            //var Result = ProductList.Select(p => p.ProductName[0])
            //            .Except(CustomerList.Select(c => c.CustomerName[0]));


            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            //var Result = ProductList.Select(p => p.ProductName.Substring(p.ProductName.Length - 3));

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #endregion

            #region Quantifiers

            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'

            //string[] lines = File.ReadAllLines("dictionary_english.txt");

            //var Result = lines.Any(l => l.Contains("ei"));

            //Console.WriteLine(Result);

            #endregion
            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.

            //var Result = from p in ProductList
            //             group p by p.Category into g
            //             where g.Any(p => p.UnitsInStock == 0)
            //             select new { Category = g.Key, Products = g };

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.Category);
            //    foreach (var product in item.Products)
            //        Console.WriteLine($"----{product.ProductName}");

            //    Console.WriteLine();
            //}

            #endregion

            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.

            //var Result = from p in ProductList
            //             group p by p.Category into g
            //             where g.All(p => p.UnitsInStock > 0)
            //             select new { Category = g.Key, Products = g };

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.Category);
            //    foreach (var product in item.Products)
            //        Console.WriteLine($"----{product.ProductName}");

            //    Console.WriteLine();
            //}


            #endregion

            #endregion

        }
    }
}
