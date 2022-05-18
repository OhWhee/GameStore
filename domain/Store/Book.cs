using System.Text.RegularExpressions;

namespace Store
{
    public class Book
    {
        public int BookId { get; }
        public string Isbn { get; }
        public string Author { get; }
        public string Title { get; }
       
        public Book(int bookId, string isbn, string author, string title)
        {
            BookId = bookId;
            Title = title;
            Isbn = isbn;
            Author = author;
        }

        internal static bool IsIsbn(string s)
        {
            if(s == null)
                return false;

            s = s.Replace("-", "")
                .Replace(" ", "")
                .ToUpper();

            return Regex.IsMatch(s, @"^ISBN\d{10}(\d{3})?$");
        }
    }
}