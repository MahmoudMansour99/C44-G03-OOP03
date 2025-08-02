using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP03
{
    internal class Employee
    {
        #region Attributes
        private char gender;
        #endregion

        #region Properties 
        private int Id {  get; set; }
        public string? Name { get; set; }
        public SecurityLevel Security {  get; set; }
        public decimal Salary { get; set; }
        public HireDate HireDate { get; set; }
        public char Gender
        {
            get { return gender; }
            set
            {
                if (value == 'M' || value == 'F')
                    gender = value;
                else
                    Console.WriteLine("Gender Must be 'M' or 'F' ");
            }
        }
        #endregion

        #region Constructor
        public Employee(int id, string? name, SecurityLevel security, decimal salary, HireDate hireDate, char gender)
        {
            Id = id;
            Name = name;
            Security = security;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"ID: {Id},\nName: {Name},\nSecurity: {Security},\n" +
                   $"Salary: {String.Format("{0:C}", Salary)},\n" +
                   $"Hire Date: {HireDate},\nGender: {Gender}";
        }
        #endregion
    }
}
