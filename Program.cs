// See https://aka.ms/new-console-template for more information
using LibraryApp;
using System.Runtime.InteropServices;
using System;
public class Program
{
    public static void Main()
{
    LibrarySystem library = new LibrarySystem();
    ShowMenu(library);
}
public static void ShowMenu(LibrarySystem library)
{
    bool close = true;

    while (close)
    {
        Console.WriteLine("\nMenu\n" +
        "1) Add book\n" +
        "2) Remove book\n" +
        "3) List books\n" +
        "4) Close\n");
        Console.Write("Choose your option from the menu: ");

        int option;
        if (!int.TryParse(Console.ReadLine(), out option))
        {
            Console.WriteLine("Invalid option. Please enter a number.");
            continue;
        }

        switch (option)
        {
            case 1:
                library.AddBook();
                break;
            case 2:
                library.RemoveBook();
                break;
            case 3:
                library.ListBooks();
                break;
            case 4:
                Console.WriteLine("Thank you!");
                close = false;
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }
    }
}
}