using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Models
{
    class Book : ILibraryManagerServic
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public string Gener { get; set; }

        public Book(string name,string author,int pageCount,string gener)
        {
            Name = name;
            Author = author;
            PageCount = pageCount;
            Gener = gener;
   
        }

        public override string ToString()
        {
            return $"Kitabin Adi:{Name}\nKiyabin Janiri:{Gener}\nKitabin Muellifi:{Author}\nKitabin Seife Sayi:{PageCount}";
        }







    }


}
