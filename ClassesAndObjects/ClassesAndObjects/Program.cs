using System;

namespace CarsAndParts
{

    public static class Program
    {
        public static void Main()
        {
            Car myToyota = new Car();
            Console.WriteLine("plese put a key");
            string mykey=Console.ReadLine();
            string result = myToyota.Start(mykey);
            Console.WriteLine(result);
            Console.ReadLine();

        }

    }
}

