using System;
namespace CarLotSimulator
{
    public class Car
    {
        public int Year { get; set;}

        public string Make { get; set;}

        public string Model { get; set;}

        public string EngineNoise { get; set;}

        public string HonkNoise { get; set;}

        public string IsDriveable { get; set;}

        public void MakeEngineNoise(string EngineNoise) //this is a method
        {
            Console.WriteLine(EngineNoise);
        }

        public void MakeHonkNoise(string HonkNoise)
        {
            Console.WriteLine(HonkNoise);
        }


        public Car()
        {
          
        }
    }
}
