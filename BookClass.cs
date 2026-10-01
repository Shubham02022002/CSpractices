using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; private set; }
        public static int BookCount { get; private set; }
        public Book(string title,string author,decimal price) {
            this.Title = title;
            this.Author = author;
            this.Price = price;
            BookCount++;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}, author:{Author}, price:{Price}");
        }

        public void ApplyDiscount(decimal percentage)
        {
            if (percentage < 0 || percentage > 100)
            {
                Console.WriteLine("Invalid discount.");
                return;
            }
            decimal discountAmount =(percentage * this.Price)/100;
            this.Price = this.Price - discountAmount;

            Console.WriteLine($"Book price after discount: {Price}");
        }

        public void ComparePrice(Book book)
        {
            if (this.Price > book.Price)
            {
                Console.WriteLine("This book is more expensive.");
            }
            else if(this.Price< book.Price) {
                Console.WriteLine($"{book.Title} is more expensive.");
            }
            else
            {
                Console.WriteLine("Both books have the same price.");
            }
        }
    }
}
