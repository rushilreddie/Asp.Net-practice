using System;

namespace ClassesAndObjects
{
    public class Person
    {
        public string Name;
   
          public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, This is {1}", to, Name);
        }
       }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Rushil";
            person.Introduce("Reddy");
        }
    }
}
