using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace LibrarySystem.Models
{
    public class Book : LibraryItem
    {
        public int Pages { get; set; }

        public Book(string id, string title, string author, int pages)
            : base(id, title, author)
        {
            Pages = pages;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Book] {Title} by {Author}, Pages: {Pages}");
        }

        public override void Borrow() => Console.WriteLine($"Borrowing Book: {Title}");
        public override void Return() => Console.WriteLine($"Returning Book: {Title}");
    }
}
