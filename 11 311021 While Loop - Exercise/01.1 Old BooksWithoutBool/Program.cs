using System;

namespace _01._1_Old_BooksWithoutBool
{
    class Program
    {
        static void Main(string[] args)
        {
            string favBook = Console.ReadLine();
            string book = Console.ReadLine();
            int bookCount = 0;

            while (book != favBook)
            {
                bookCount++;
                book = Console.ReadLine();

                if (book == "No More Books")
                {
                    break;
                }
            }
            if (book == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {bookCount} books.");
            }
            else
            {
                Console.WriteLine($"You checked {bookCount} books and found it.");
            }
        }
    }
}
