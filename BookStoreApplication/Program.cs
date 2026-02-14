using System;

namespace BookStoreApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO:
            // 1. Read initial input
            // Format: BookID Title Price Stock
            Console.WriteLine("Enter book id: ");
            string bookId = Console.ReadLine();
            Console.WriteLine("Enter title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter price: ");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter stock: ");
            int stock = int.Parse(Console.ReadLine());
            Book book = new Book();

            book.Id = bookId;
            book.Title = title;
            book.Price = price;
            book.Stock = stock;

            BookUtility utility = new BookUtility(book);

            while (true)
            {
                // TODO:
                // Display menu:
                // 1 -> Display book details
                // 2 -> Update book price
                // 3 -> Update book stock
                // 4 -> Exit
                Console.WriteLine("1 -> Display book details");
                Console.WriteLine("2 -> Update book price");
                Console.WriteLine("3 -> Update book stock");
                Console.WriteLine("4 -> Exit");

                Console.WriteLine("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine()); // TODO: Read user choice

                switch (choice)
                {
                    case 1:
                        utility.GetBookDetails();
                        break;

                    case 2:
                        // TODO:
                        // Read new price
                        // Call UpdateBookPrice()
                        int newPrice = int.Parse(Console.ReadLine());
                        utility.UpdateBookPrice(newPrice);
                        break;

                    case 3:
                        // TODO:
                        // Read new stock
                        // Call UpdateBookStock()
                        int newStock = int.Parse(Console.ReadLine());
                        utility.UpdateBookStock(newStock);
                        break;

                    case 4:
                        Console.WriteLine("Thank You");
                        return;

                    default:
                        // TODO: Handle invalid choice
                        Console.WriteLine("Please enter a valid choice in range of 1-4");
                        break;
                }
            }
        }
    }
}
