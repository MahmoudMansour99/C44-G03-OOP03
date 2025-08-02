using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP03.Inheritence
{
    internal class Child : Parent
    {
        #region Properties
        public int Z { get; set; }
        #endregion

        #region Constructor
        public Child(int x, int y, int z):base(x,y)
        {
            Z = z;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"X = {X}, Y = {Y}, Z = {Z}";
        }

        public override int Product()
        {
            return X * Y * Z;
        }
        public new void MyFun()
        {
            Console.WriteLine("Iam Child");
        }
        #endregion
    }
}
