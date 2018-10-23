using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Demo
{
                //This would be an example of Inheritance
    class Cars : CarProperties
    {
        //This would be an example of Encapsulation
        public string Name { get; set; }
        public string Model { get; set; }
        public int YearOfCar { get; set; }
    }
}
