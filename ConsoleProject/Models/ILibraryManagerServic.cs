using System;
using System.Collections.Generic;
using System.Text;
using ConsoleProject.Models;
using ConsoleProject.Exceptions;
using ConsoleProject.Inteface;

namespace ConsoleProject.Models
{
    class ILibraryManagerServic : ILibraryManager
    {
        List<Book> Books = new List<Book>();

        public void Add(string name, string author, int pageCount, string gener)
        {
            if (Books.FindAll(book => book.Name.Contains(name)).ToString() != name)
            {
                Books.Add(new Book(name, author, pageCount, gener)
                {
                    Name = name,
                    Author = author,
                    PageCount = pageCount,
                    Gener = gener
                }); ;
            }
            else
            {
                throw new SameBookalreadyAddedExpection("Eyni adda yalniz bir kitab ola biler");
            }
        }

        public List<Book> Filter(string search)
        {
            return Books.FindAll(delegate (Book book) { return book.Gener.ToLower().Contains(search.Trim().ToLower()) || book.Author.ToLower().Contains(search.Trim().ToLower());  });
            //Books.FindAll(book => book.Author.ToLower().Contains(search.Trim().ToLower()))
            //|| Books.FindAll(book => book.Author.ToLower().Contains(search.Trim().ToLower()));
        }

        public void Search(string name)
        {
           
        }

        public string ShowInfo(string name)
        {
            if (Books.FindAll(book => book.Name.ToLower().Contains(name.Trim().ToLower())) ==  null)
            {
                throw new BookNotFoundException("Bu Adda Kitabb  Movcut Deyil");
            }
            return Books.ToString();
        }
    }
}
