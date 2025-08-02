using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP03.Inheritance
{
    internal class Book
    {
        #region Properties
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        #endregion

        #region Constructor
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }
        #endregion

        #region Methods
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
        }
        #endregion
    }
}
