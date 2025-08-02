 Assignment
﻿using C44_G03_OOP03.Inheritance;

﻿using C44_G03_OOP03.Inheritence;
using System;
using Common;
 master

namespace C44_G03_OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
 Assignment
            #region 1.	Design and implement a Class for the employees in a company
            //Employee employee;
            //employee = new Employee(1, "Mahmoud", SecurityLevel.Developer, 8500.00m, new DateTime(2024, 1, 22), 'M');

            //Console.WriteLine(employee);
            #endregion

            #region Question 2 & 3 & 4
            //Employee[] EmpArr = new Employee[3];

            //EmpArr[0] = new Employee(1, "Ali", SecurityLevel.DBA, 15000m, new HireDate(12, 2, 2019), 'M');
            //EmpArr[1] = new Employee(2, "Sara", SecurityLevel.Guest, 5000m, new HireDate(5, 7, 2021), 'F');
            //EmpArr[2] = new Employee(3, "Omar", SecurityLevel.DBA, 18000m, new HireDate(25, 12, 2018), 'M');

            //Console.WriteLine("Original Array:");
            //foreach (var emp in EmpArr)
            //    Console.WriteLine(emp);

            //for (int i = 0; i < EmpArr.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < EmpArr.Length; j++)
            //    {
            //        if (EmpArr[i].HireDate.ToDateTime() > EmpArr[j].HireDate.ToDateTime())
            //        {
            //            Employee temp = EmpArr[i];
            //            EmpArr[i] = EmpArr[j];
            //            EmpArr[j] = temp;
            //        }
            //    }
            //}

            //Console.WriteLine("\nSorted Array by Hire Date:");
            //foreach (var emp in EmpArr)
            //    Console.WriteLine(emp);

            #endregion

            #region 5-Design a program for a library management system where:
            EBook eBook = new EBook("Requiem for a Dream: A Novel", "Selby Jr., Hubert", "9781560252481", 446);

            PrintedBook printedBook = new PrintedBook("Dark Matter: A Novel", "Crouch, Blake", "9781101904237", 325);

            Console.WriteLine("EBook Info:");
            eBook.DisplayInfo();

            Console.WriteLine("\nPrinted Book Info:");
            printedBook.DisplayInfo();

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

 master
            #endregion
        }
    }
}
