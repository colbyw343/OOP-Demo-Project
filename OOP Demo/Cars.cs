using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Demo
{
                //This would be an example of Inheritance because Inheritance is where a method or class "inherits" another class by taking
                //the other class's properties
    class Cars : CarProperties
    {
        //By creating a class with some properties, this is an instance of Encapsulation. Instead of having to give an object these properties manually, we set
        //up a class with the properties.
        public string Name { get; set; }
        public string Model { get; set; }
        public int YearOfCar { get; set; }
    }
}
