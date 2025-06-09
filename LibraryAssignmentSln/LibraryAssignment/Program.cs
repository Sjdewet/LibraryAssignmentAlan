namespace LibraryAssignment
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static List<LibraryItem> libraryItems = new List<LibraryItem>();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n Summers Library Menu:");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Remove Item");
                Console.WriteLine("3. Search Item");
                Console.WriteLine("4. Display All Items");
                Console.WriteLine("5. Exit");
                Console.Write("HII! Please select an option: ");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        AddItem();
                        break;
                    case "2":
                        RemoveItem();
                        break;
                    case "3":
                        SearchItem();
                        break;
                    case "4":
                        DisplayItems();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddItem()
        {
            try
            {
                Console.Write("Please enter item type (Book/Magazine/DVD): ");
                string type = Console.ReadLine().ToLower();

                Console.Write("Please enter ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Please enter Title: ");
                string title = Console.ReadLine();
                Console.Write("Please enter Year Published: ");
                int year = int.Parse(Console.ReadLine());

                switch (type)
                {
                    case "book":
                        Console.Write("Please enter Author: ");
                        string author = Console.ReadLine();
                        Console.Write("Please enter Genre: ");
                        string genre = Console.ReadLine();
                        libraryItems.Add(new Book { ID = id, Title = title, YearPublished = year, Author = author, Genre = genre });
                        break;
                    case "magazine":
                        Console.Write("Please enter Issue Number: ");
                        int issue = int.Parse(Console.ReadLine());
                        Console.Write("Enter Month: ");
                        string month = Console.ReadLine();
                        libraryItems.Add(new Magazine { ID = id, Title = title, YearPublished = year, IssueNumber = issue, Month = month });
                        break;
                    case "dvd":
                        Console.Write("Please enter Director: ");
                        string director = Console.ReadLine();
                        Console.Write("Enter Duration (in minutes): ");
                        double duration = double.Parse(Console.ReadLine());
                        libraryItems.Add(new DVD { ID = id, Title = title, YearPublished = year, Director = director, Duration = duration });
                        break;
                    default:
                        Console.WriteLine("Unknown item type.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void RemoveItem()
        {
            try
            {
                Console.Write("Please enter ID to remove: ");
                int id = int.Parse(Console.ReadLine());
                var item = libraryItems.FirstOrDefault(i => i.ID == id);
                if (item != null)
                {
                    libraryItems.Remove(item);
                    Console.WriteLine("Item removed.");
                }
                else
                {
                    Console.WriteLine("Item not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void SearchItem()
        {
            try
            {
                Console.Write("Please enter ID to search: ");
                int id = int.Parse(Console.ReadLine());
                var item = libraryItems.FirstOrDefault(i => i.ID == id);
                if (item != null)
                {
                    item.Display();
                }
                else
                {
                    Console.WriteLine("Item not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void DisplayItems()
        {
            if (libraryItems.Count == 0)
            {
                Console.WriteLine("Library is empty.");
                return;
            }

            foreach (var item in libraryItems)
            {
                item.Display();
            }
        }
    }
}
