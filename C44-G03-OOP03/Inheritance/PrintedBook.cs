using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP03.Inheritance
{
    internal class PrintedBook : Book
    {
        #region Properties
        public int PageCount { get; set; }
        #endregion

        #region Constructors
        public PrintedBook(string title, string author, string isbn, int pageCount)
        : base(title, author, isbn)
        {
            PageCount = pageCount;
        }
        #endregion

        #region Methods
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Page Count: {PageCount} pages");
        }
        #endregion
    }
}
