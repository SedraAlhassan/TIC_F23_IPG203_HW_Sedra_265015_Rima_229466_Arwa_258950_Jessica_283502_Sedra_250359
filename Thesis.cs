using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Models
{
    public class Thesis : LibraryItem
    {
        public string University { get; set; }

        public Thesis(string id, string title, string author, string uni)
            : base(id, title, author)
        {
            University = uni;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Thesis] {Title} by {Author}, University: {University}");
        }

        public override void Borrow() => Console.WriteLine($"Borrowing Thesis: {Title}");
        public override void Return() => Console.WriteLine($"Returning Thesis: {Title}");
    }
}
