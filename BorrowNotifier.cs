using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using LibrarySystem.Models;

namespace LibrarySystem.Services
{
    public delegate void BorrowHandler(string message);

    public class BorrowNotifier
    {
        public event BorrowHandler OnBorrowed;

        public void BorrowItem(LibraryItem item)
        {
            item.Borrow();
            OnBorrowed?.Invoke($"{item.Title} has been borrowed!");
        }
    }
}
