using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
   


        class Program
        {
            static void Main(string[] args)
            {
                int firstNum;
                int secondNum;                  
                string operation;
                int answer;

                Console.WriteLine("Hello");
                Console.ReadLine();

                Console.Write("Enter the first number: ");
                firstNum = Convert.ToInt32(Console.ReadLine());

                Console.Write("Now enter your second number: ");
                secondNum = Convert.ToInt32(Console.ReadLine());
                Console.Write("enter your operation ( x , / , +, -) ");
                operation = Console.ReadLine();

                if (operation == "x")
                {
                    answer = firstNum * secondNum;
                    Console.WriteLine(firstNum + " x " + secondNum + " = " + answer);
                    Console.ReadLine();
                }
                else if (operation == "/")
                {
                    answer = firstNum / secondNum;
                    Console.WriteLine(firstNum + " / " + secondNum + " = " + answer);
                    Console.ReadLine();
                }

                else if (operation == "+")
                {
                    answer = firstNum + secondNum;
                    Console.WriteLine(firstNum + " + " + secondNum + " = " + answer);
                    Console.ReadLine();
                }
                else if (operation == "-")
                {
                    answer = firstNum - secondNum;
                    Console.WriteLine(firstNum + " - " + secondNum + " = " + answer);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Sorry start again");    
                    Console.ReadLine();
                }
            }
        }
    }