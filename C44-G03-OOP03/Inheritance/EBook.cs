using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP03.Inheritance
{
    internal class EBook : Book
    {
        #region Properties
        public double FileSize { get; set; }
        #endregion

        #region Constructor
        public EBook(string title, string author, string isbn, double fileSize) : base(title, author, isbn)
        {
            FileSize = fileSize;
        }
        #endregion

        #region Methods
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"File Size: {FileSize} MB");
        }
        #endregion
    }
}
