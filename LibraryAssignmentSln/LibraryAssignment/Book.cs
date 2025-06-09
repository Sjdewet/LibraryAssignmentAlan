using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAssignment
{
    public class Book : LibraryItem
    {
        public string Author { get; set; }
        public string Genre { get; set; }

        public override void Display()
        {
            Console.WriteLine($"[Book] ID: {ID}, Title: {Title}, Author: {Author}, Genre: {Genre}, Year: {YearPublished}");
        }
    }
}
