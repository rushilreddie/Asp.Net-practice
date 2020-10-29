using System;

namespace CarsAndParts
{
    public class Car
    {
        public string Key;
        public string Transmission;

        public string Start(string Key)
        {
            return "I have started using" + Key;
        }

        public void Shaft(string to)
        {
            Console.WriteLine("Fit inside", to, Transmission);
        }

    }
}

