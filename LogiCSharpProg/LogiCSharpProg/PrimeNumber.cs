using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiCSharpProg
{
    internal class PrimeNumber
    {

        // The Number Divisible by 1 or itself is a Prime Number
        public void CheckPrimeno()
        { 
            // Taking Input From User to Check prime no. or not
            Console.Write("Enter the Number to check Prime or not:");
            int Number = Convert.ToInt32(Console.ReadLine()); // Storing the no input by use in varible & Convert into int..
            //defing logic if lese to check prime or Not..
            if (Number > 1)
            { 
                // using for loop To Check number is divisible by any number Except 1 or itself..
                for (int i = 2; i <= Number / 2; i++)
                {
                    if (Number % i == 0)
                    {

                        Console.WriteLine("The Number You Enter {0} is not prime number", Number);
                        break;
                        
                    }
                    else
                    {
                        Console.WriteLine("The Number You Enter {0} is a prime number", Number);
                        return;
                    }

                }
            }
             
        }
    }
}
