using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Pratice2_StephanieLopez
{
    internal class Car
    {
        //Part 1 of project
        //Fields
        private string _make;
        private string _model;
        private int _year;
        private int _mileage;

        //Constructor 1 
        public Car()
        {
            _make = "unassigned";
            _model = "unassigned";
            _year = 0;
            _mileage = 0;
        }

        //Constrctor 2 
        public Car(string make, string model)
        {
            _make = make;
            _model = model;
            _year = 0;
            _mileage = 0;
        }

        //Constructor 3
        public Car(string make, string model, int year, int mileage)
        {
            _make = make;
            _model = model;
            _year = year;
            _mileage = mileage;
        }

        //Properties
        public override string ToString()
        {
            return $"{_year} {_make} {_model} - Mileage {_mileage}";
        }
    }
}
