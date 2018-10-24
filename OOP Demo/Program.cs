using System;

namespace OOP_Demo
{
    class Program
    {
        //Polymorphism means "in many different forms". Using this meaning we can see that this would be an example of Polymorphism.
        //We set up 3 different methods, all with the same name, but we pass in different variables (i.e. string, int, or nothing at all).
        //So then, whenever we want to use this method, we have to specify which method we want to use by putting in either an int, string, or leave it blank.
        private void DoThings() { }
        private void DoThings(string a) { }
        private void DoThings(int b) { }

        static void Main(string[] args)
        {
            CarDealer();
        }

        //This method is an example of Polymorphism???
        private static void CarDealer()
        {
            Console.WriteLine("These are all the cars that a car dealer has:");
            Console.WriteLine("Make...Model...Year");
            Cars Ford = new Cars()
            {
                Name = "Ford",
                Model = "F-150",
                YearOfCar = 2018,
                HasEngine = true,
                Has4Wheels = true,
                IsTruck = true
            };
            Cars Chevy = new Cars()
            {
                Name = "Chevrolet",
                Model = "Camaro",
                YearOfCar = 2015,
                HasEngine = true,
                Has4Wheels = true,
                IsTruck = false
            };
            Cars Honda = new Cars()
            {
                Name = "Honda",
                Model = "Civic",
                YearOfCar = 2005,
                HasEngine = true,
                Has4Wheels = true,
                IsTruck = false
            };
            Console.WriteLine($"{Ford.Name}  {Ford.Model}  {Ford.YearOfCar}");
            Console.WriteLine($"{Chevy.Name} {Chevy.Model} {Chevy.YearOfCar}");
            Console.WriteLine($"{Honda.Name} {Honda.Model} {Honda.YearOfCar}");
            Console.ReadLine();
        }
    }
}
