using System.Collections.Generic;
using ConsoleProject.Models;

namespace ConsoleProject.Inteface
{
    interface ILibraryManager
    {

        public void Add(string name, string author, int pageCount, string gener);

        public string ShowInfo(string name);

        public void Search(string name);

        public List<Book> Filter(string search);

    }
}
