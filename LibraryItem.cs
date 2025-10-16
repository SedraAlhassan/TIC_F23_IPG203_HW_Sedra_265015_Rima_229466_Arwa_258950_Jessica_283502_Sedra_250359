using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace LibrarySystem.Models
{
    public abstract class LibraryItem : IBorrowable
    {
        private string id; // تغليف
        public string Title { get; set; }
        public string Author { get; set; }

        public string Id
        {
            get { return id; }
            private set { id = value; } 
        }

        public LibraryItem(string id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
        }

        public abstract void DisplayInfo();
        public abstract void Borrow();
        public abstract void Return();
    }
}
