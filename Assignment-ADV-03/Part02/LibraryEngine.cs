namespace Assignment_ADV_03.Part02
{
    public delegate T BookDelegate<T>(Book book);

    public class LibraryEngine
    {
        public static void ProcessBooks<T>( List<Book> books, BookDelegate<T> bookDelegate)
        {
            foreach (var book in books)
            {
                Console.WriteLine(bookDelegate(book));
            }
        }

        public static void ProcessBooks2<T>(List<Book> books, Func<Book, T> bookDelegate)
        {
            foreach (var book in books)
            {
                Console.WriteLine(bookDelegate(book));
            }
        }
    }
}
