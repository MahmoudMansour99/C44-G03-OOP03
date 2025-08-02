using C44_G03_OOP03.Inheritence;

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

            Child child = new Child(10, 20, 30);

            Console.WriteLine(child);
            Console.WriteLine(child.Product());
            child.MyFun();
            #endregion
        }
    }
}
