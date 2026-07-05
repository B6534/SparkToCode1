using System;

namespace programm_1;

class Program
{
    static void Main(string[] args)
    {
        /// task 1 ////
        // try
        // {
        //     Console.WriteLine("Enter first number:");
        //     float firstNumber = float.Parse(Console.ReadLine());
        //     
        //     Console.WriteLine("Enter second number:");
        //     float secondNumber = float.Parse(Console.ReadLine());
        //     
        //     double result = Math.Abs(secondNumber - firstNumber);
        //     Console.WriteLine(result);
        // }
        // catch (Exception )
        // {
        //     Console.WriteLine("error: please type valid number only ");
        ////}//
        
        // Task 2 // 
        
        Console.WriteLine("Enter a number:");
        float number = float.Parse(Console.ReadLine());
        double result = Math.Sqrt(number);
        double result2 = Math.Pow(number, 2);
        Console.WriteLine("Squared root: "+ result);
        Console.WriteLine("squard: " + result2);
        
    }
        

    }
