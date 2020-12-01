using System;

class Program
{
    static void Main(string[] args)
    {

        double usd = 0;
        double inr = 0;
        double value = 0;

        Console.Write("Enter amount in USD: ");
        usd = double.Parse(Console.ReadLine());

        Console.Write("Enter the USD value :");
        value = double.Parse(Console.ReadLine());

        inr = usd * value;
        Console.WriteLine("USD " + usd + "-> INR " + inr);
    }
}