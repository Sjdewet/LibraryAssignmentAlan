using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAssignment
{
    public class DVD : LibraryItem
    {
        public string Director { get; set; }
        public double Duration { get; set; }

        public override void Display()
        {
            Console.WriteLine($"[DVD] ID: {ID}, Title: {Title}, Director: {Director}, Duration: {Duration} mins, Year: {YearPublished}");
        }
    }
}
