using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Book
    {
        string title, author;
        DateTime reliseDate;

        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime ReleaseDate { get; set; }


        public Book (string title, string author, DateTime ReliseDate ) {
          Title = title;
         Author= author;
         ReliseDate= reliseDate;    
        }
}
       

    
}
