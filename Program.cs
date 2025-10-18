using System;
using LibrarySystem.Models;
using LibrarySystem.Services;
using LibrarySystem.Utils;

namespace LibrarySystem
{
    class Program
    {
        static void Main()
        {
            Library lib = new Library();
            Book b1 = new Book("B1", "C# Basics", "Mohamed Ali", 275);
            Magazine m1 = new Magazine("M1", "Tech Monthly", "Samer Samer", 45);
            Thesis t1 = new Thesis("T1", "AI in Healthcare", "Ali Ahmed", "SVU");

            lib.AddItem(b1);
            lib.AddItem(m1);
            lib.AddItem(t1);
            lib.ShowAllItems();
            Console.WriteLine(Validator.ValidateTitle("Hello World") ? "Valid Title" : "Invalid Title");

            BorrowNotifier notifier = new BorrowNotifier();
            notifier.OnBorrowed += (msg) => Console.WriteLine($"Event Triggered: {msg}");
            notifier.BorrowItem(b1);

            ItemCounter c1 = new ItemCounter();
            ItemCounter c2 = new ItemCounter();
            Console.WriteLine($"Total Items Counted: {ItemCounter.TotalItems}");
        }
    }
}
