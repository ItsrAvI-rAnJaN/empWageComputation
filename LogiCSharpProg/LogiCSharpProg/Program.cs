using System;

namespace LogiCSharpProg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to C# Logical Programming*****\n ");
            Console.WriteLine("Q1.To Print Fibonacci Series ");
            Console.WriteLine("Q2.Check The Number Is Perfect or Not");
            Console.WriteLine("Q3. Check The Number is Prime or Not");

            // Taking Input From User of Question Number..
            Console.Write("->Enter The Choice of Question Number : ");

            // Storing The input Fom User in Choice Varible & Convert Into Integer..
            int Choice = Convert.ToInt32(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    // Creating Object of FibonacciSeries class..
                    FibonacciSeries objfibonacci = new FibonacciSeries();

                    // Calling Method Define in FibonacciSeries Class
                    objfibonacci.calcFibonacciSeries();
                    break;
                case 2:
                    // Creating Object of PerfectNumber class..
                    PerfectNumber objperfectno = new PerfectNumber();

                    //calling Method Define in PerfectNumber class
                    objperfectno.CheckPerfectNo();
                    break;
                case 3:
                    // Creating object/instance of class PrimeNumber
                    PrimeNumber objprimeno = new PrimeNumber();

                    // calling Method Define in Class PrimeNumber
                    objprimeno.CheckPrimeno();
                    break;
                default:
                    Console.WriteLine("Enter Valid Question Number");
                    break;


            }
            Console.ReadKey();
        }
    }
}