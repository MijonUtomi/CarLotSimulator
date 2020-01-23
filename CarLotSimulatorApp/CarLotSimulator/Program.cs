using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            Car green = new Car();
            green.Year = 1970;
            green.Make = "ford";
            green.Model = "F-150";
            green.EngineNoise = "loud";
            green.HonkNoise = "Noticeable";
            green.IsDriveable = "teleporting";
            green.EngineNoise = "Loud";
            green.HonkNoise = "Noticeable";

            green.MakeEngineNoise(green.EngineNoise);
            green.MakeHonkNoise(green.HonkNoise);

            Car black = new Car();

            black.Year = 2019;
            black.Make = "honda";
            black.Model = "accord";
            black.EngineNoise = "low";
            black.HonkNoise = "Noticeable";
            black.IsDriveable = "ghosting";
            black.EngineNoise ="low"; 
            black.HonkNoise =  "Noticeable";

            black.MakeEngineNoise(black.EngineNoise);
            black.MakeHonkNoise(black.HonkNoise);


            Car burgundy = new Car();
            burgundy.Make = "bugatti";
            burgundy.Model = "spinner";
            burgundy.EngineNoise = "jaws";
            burgundy.HonkNoise = "yoda";
            burgundy.IsDriveable = "flying";
            burgundy.EngineNoise ="jaws";
            burgundy.HonkNoise = "yoda";

            burgundy.MakeEngineNoise(burgundy.EngineNoise);
          burgundy.MakeHonkNoise(burgundy.HonkNoise);


            Console.ReadLine();
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }

        private static void MakeHonkNoise(object noticeable)
        {
            throw new NotImplementedException();
        }

        private static void MakeEngineNoise(object loud)
        {
            throw new NotImplementedException();
        }
    }
}
