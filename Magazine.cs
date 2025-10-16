using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Models
{
    public class Magazine : LibraryItem
    {
        public int IssueNumber { get; set; }

        public Magazine(string id, string title, string author, int issue)
            : base(id, title, author)
        {
            IssueNumber = issue;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Magazine] {Title}, Issue: {IssueNumber}");
        }

        public override void Borrow() => Console.WriteLine($"Borrowing Magazine: {Title}");
        public override void Return() => Console.WriteLine($"Returning Magazine: {Title}");
    }
}
