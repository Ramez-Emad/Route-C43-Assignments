using Assignment_ADV_03.Part02;
using Assignment_ADV_03.Part03;
using System.Collections.Generic;

namespace Assignment_ADV_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part02

                List<Book> books = new List<Book>()
                {
                    new Book("1", "DB", new []{"Abdelrahman" , "Ramez"}, DateTime.Now,100),
                    new Book("2", "C#", new []{"Ahmed" , "Alaa"}, DateTime.Now,200),
                    new Book("3", "OOP", new []{"Mohammed" ,"Faroul"}, DateTime.Now,300),
                };

            #region a)Create User Defined Delegate with the same signature of methods existed in Bookfunctions class.

            //BookDelegate<string> title = BookFunctions.GetTitle;
            //BookDelegate<string> authors = BookFunctions.GetAuthors;
            //BookDelegate<decimal> price = BookFunctions.GetPrice;

            //LibraryEngine.ProcessBooks(books, price);

            #endregion



            #region b)Use the Proper build in delegate.

            //Func<Book, string> func = BookFunctions.GetTitle;
            //LibraryEngine.ProcessBooks2(books, func);

            #endregion



            #region c) Anonymous Method(GetISBN)

            //LibraryEngine.ProcessBooks2(books, delegate (Book b) { return b.ISBN; });
            #endregion



            #region d)Lambda Expression (GetPublicationDate)

            //LibraryEngine.ProcessBooks2(books, b => $"Publication Date : {b.PublicationDate}");
            #endregion

            #endregion

            #region Part03

                List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


                #region ScratchExist

                bool exist = numbers.ScratchExist(x => x == 5);
                System.Console.WriteLine(exist);

                #endregion

                #region ScratchFind
                int find = numbers.ScratchFind(x => x == 5);
                System.Console.WriteLine(find);
                #endregion

                #region ScratchFindAll
                List<int> findAll = numbers.ScratchFindAll(x => x > 5);
                foreach (var item in findAll)
                {
                    System.Console.WriteLine(item);
                }
                #endregion

                #region ScratchFindIndex
                int findIndex = numbers.ScratchFindIndex(x => x == 5);
                System.Console.WriteLine(findIndex);
                #endregion

                #region ScratchFindLastIndex
                int findLastIndex = numbers.ScratchFindLastIndex(x => x == 5);
                System.Console.WriteLine(findLastIndex);
                #endregion

                #region ScratchForEach
                numbers.ScratchForEach(x => System.Console.WriteLine(x));

                #endregion

                #region ScratchTrueForAll
                bool trueForAll = numbers.ScratchTrueForAll(x => x > 0);
                System.Console.WriteLine(trueForAll);
                #endregion


            #endregion
        }
    }
}
