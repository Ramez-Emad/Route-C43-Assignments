namespace OOP4_Task
{
    public struct Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}";
        }
    }

    public class LibraryItem
    {
        public int ItemId { get; set; }
        public bool IsAvailable { get; private set; } = true;

        public void CheckOut()
        {
            IsAvailable = false;
        }

        public void ReturnItem()
        {
            IsAvailable = true;

        }
    }

    public class BorrowedBook : LibraryItem
    {
        public Book BookDetails { get; set; }
        public string BorrowerName { get; set; }
        public DateTime BorrowedDate { get; set; }

        public BorrowedBook(int itemId, Book bookDetails, string borrowerName, DateTime borrowedDate)
        {
            ItemId = itemId;
            BookDetails = bookDetails;
            BorrowerName = borrowerName;
            BorrowedDate = borrowedDate;
        }

        public int CalculateBorrowDuration()
        {
            return (DateTime.Now - BorrowedDate).Days;
        }

        public override string ToString()
        {
            return $"{BookDetails}, Borrowed by: {BorrowerName}, Borrowed Date: {BorrowedDate:d}\n";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Intro to OOP", "Ahmed Khaled", "1234567890");

            BorrowedBook borrowedBook = new BorrowedBook(1, book, "Ramez Emad", DateTime.Now.AddDays(-5));

            Console.WriteLine(borrowedBook);

            
            borrowedBook.CheckOut();

            Console.WriteLine($"Days borrowed: {borrowedBook.CalculateBorrowDuration()}\n");

            borrowedBook.ReturnItem();

            Console.WriteLine($"Is the book available? {borrowedBook.IsAvailable}");
        }
    }
    
}
