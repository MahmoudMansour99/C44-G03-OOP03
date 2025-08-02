using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP03
{
    internal class Car
    {
        #region Attributes
        private int id = default; // 4 Bytes
        private string? model = default; // 4 Bytes
        private double speed = default; // 8 Bytes
        #endregion

        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; } 
        }
        public string? Model
        {
            get { return model; }
            set { model = value; }
        }
        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        #endregion

        #region Constructor
        // Embty Parameterless Constructor - Default Constructor -- Auto Genarated by Compiler
        //public Car()
        //{
            
        //}
        // User Defined Constructor
        public Car(int id, string? model, double speed)
        {
            this.id = id;
            this.model = model;
            this.speed = speed;
        }
        public Car(int id , string? model) : this(id, model, 250)
        {
            //this.id = id;
            //this.model = model;
            //this.speed = 250;
        }
        public Car(int id) : this(id, "BMW", 250)
        {
            //this.id = id;
            //this.model = "BMW";
            //this.speed = 250;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Id = {id}\nModel = {model}\nSpeed = {speed}";
        } 
        #endregion
    }
}
