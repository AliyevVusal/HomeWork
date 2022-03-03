using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Exceptions
{
    class BookNotFoundException : Exception
    {
        public BookNotFoundException(string message):base(message)
        {

        }
        public BookNotFoundException(string message2,BookNotFoundException bookNotFoundException):base(message2,bookNotFoundException)
        {

        }
    }
}
