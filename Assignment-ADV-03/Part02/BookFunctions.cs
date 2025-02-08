namespace Assignment_ADV_03.Part02
{
    public class BookFunctions
    {
        public static string GetTitle(Book book)
        {
            return book?.Title ?? "";
        }

        public static string GetAuthors(Book book)
        {
            return book?.Authors != null ? string.Join(", ", book.Authors) : "" ?? "";
        }

        public static decimal GetPrice(Book book)
        {
            return book?.Price ?? 0;
        }

    }
}
