using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryAssignment
{
    public abstract class LibraryItem
    {
        public int ID { get; set; }
        public required string Title { get; set; }
        public int YearPublished { get; set; }

        public abstract void Display();
    }
}