using C44_G03_OOP03.Inheritence;
using System;
using Common;

namespace C44_G03_OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Class
            //Car C01; // Create Instance | Object from Car
            //         // 1. Allocate Required Bytes in Stack [Null]

            ////C01 = new Car(10, "Audi", 500); // Allocate Required Bytes in Heap (16 Bytes)

            //C01 = new Car(10, "Ferrari");
            //Console.WriteLine(C01);
            ////Console.WriteLine(C01.ToString());


            #endregion

            #region Inheritence
            //Parent parent = new Parent(10, 20);
            //Console.WriteLine(parent);
            //Console.WriteLine(parent.Product());
            //parent.MyFun();

            //Child child = new Child(10, 20, 30);

            //Console.WriteLine(child);
            //Console.WriteLine(child.Product());
            //child.MyFun();
            #endregion

            #region Access Modifier 
            //TypeA typeA = new TypeA();

            //typeA.A = 1; // Not valid because it is private
            //typeA.B = 1; // not valid because it is internal in the other projected
            //typeA.C = 1; // public can be shown every where
            //typeA.X = 1; // private protected without inheritence means private
            //typeA.Y = 1; // protected without inheritance means private
            //typeA.Z = 1; // protected internal without inheritence means internal can't be showsn in the other project
            #endregion

            #region Relation Ship Between Classes

            #endregion
        }
    }
}
