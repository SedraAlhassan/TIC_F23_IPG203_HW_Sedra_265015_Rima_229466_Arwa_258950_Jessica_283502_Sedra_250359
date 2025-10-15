using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Models
{
    public class Library
    {
        private List<LibraryItem> items = new List<LibraryItem>();

        public void AddItem(LibraryItem item) => items.Add(item);

        public void ShowAllItems()
        {
            foreach (var item in items)
            {
                item.DisplayInfo(); // Polymorphism
            }
        }
    }
}
