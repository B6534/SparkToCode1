using System.Runtime.InteropServices;

namespace Tasks;

class Program
{
    static void Main(string[] args)
    {
        // Task 1 //////////////////////
        Console.WriteLine("Personal details");
        string Name = "Sara";
        int Age = 21;
        double height = 1.65;
        bool student = true;
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Height: " + height);
        Console.WriteLine("Student: " + student);
        
        
        //// Task 2 ///////
        
        Console.WriteLine("Enter Length");
        int  length = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter width");
        int width = int.Parse(Console.ReadLine());
        float Area = length * width;
        float perimeter = (length + width) * 2;
        Console.WriteLine("Perimeter: " + perimeter);
        Console.WriteLine("Area: " + Area);
        
        /// Task 3 /////
        
         Console.WriteLine("Enter a number: ");
         int number = int.Parse(Console.ReadLine());
        
         if (number % 2 == 0)
             {
                 Console.WriteLine("The number is even");
             }
         else
             {
                 Console.WriteLine("The number is odd");
            }
            
            
            
            //////Task 4 ///////
            
            Console.WriteLine("Enter your Age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("do you have your id with you? yes or no?");
            string Id = Console.ReadLine();
            bool idcheck = (Id == "yes");
            
            if (age >= 18 && idcheck)
                {
                Console.WriteLine("you can vote");
                }
            else
                {
                Console.WriteLine("you can not vote");
                }
            
            

            //// Task 5 //
            
            Console.WriteLine("Enter a your grade: ");
            char grade = Console.ReadLine()[0];
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                    Console.WriteLine("Good");
                    break;
                case 'D':
                    Console.WriteLine("Pass");
                    break;
                case 'E':
                    Console.WriteLine("Fail");
                    break;
                    default:
                        Console.WriteLine("invalid grade");
                        break;
            }
            
            
            //// Task 6 ////
            
            Console.WriteLine("Enter a temperature in Celsius: :");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("Fahrenheit is " + fahrenheit);
            
            if (celsius < 10)
            {
                Console.WriteLine("Cold");
                
            }
            else if (celsius >= 10 && celsius <= 30)
            {
                Console.WriteLine("Mild");
                
            }
            else 
            {
                Console.WriteLine("Hot");
            }
           
            
            //// task 7 //
            
            Console.WriteLine("Enter your Age: ");
            int age = int.Parse(Console.ReadLine());
            if ( age <= 12)
            {
                Console.WriteLine("children tacket is 2000 OMR");
            }
            else if ( age >= 13 && age <=59 )
            {
                Console.WriteLine("Adults tacket is 5000 OMR");
            }
            else
            {
                Console.WriteLine("Seniors  tacket is 3000 OMR");
            }
            
            //// Task 8///
        Console.WriteLine("Enter Total bill: ");
        double totalBill = double.Parse(Console.ReadLine());
        Console.WriteLine("Are you member? ");
        string member = Console.ReadLine();
        bool emember = (member == "yes");
        double discount = 0.0;
        
        if (totalBill > 20 && emember)
        { 
            discount = totalBill * 0.15;
        }
        double finalamount = totalBill - discount;
        Console.WriteLine("orginal bill: " + totalBill );
        Console.WriteLine("Discount amount: " + discount );
        Console.WriteLine("final amount: " + finalamount );
        
       
        
        
        // ///// task 9 ///
        //
        Console.WriteLine("Enter Number from 1 to 7 ");
        int number = int.Parse(Console.ReadLine());
        
        switch (number)
        {
            case 1:
                Console.WriteLine( "Sunday ");
                break;
            case 2:
                Console.WriteLine( "Monday ");
                break;
            case 3:
                Console.WriteLine( "Tuesday ");
                break;
            case 4:
                Console.WriteLine( "Wednesday ");
                break;
            case 5:
                Console.WriteLine( "Thursday ");
                break;
            case 6:
                Console.WriteLine( "Friday ");
                break;
            case 7:
                Console.WriteLine( "Saturday ");
                break;
            
        
        ///// Task 10 /// //
        Console.WriteLine("Enter a Frist Number:");
        float fristNumber = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter a Second Number:");
        float secondNumber = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter a operator (+,-,*,/,%");
        char operatorChar = char.Parse(Console.ReadLine());
        switch (operatorChar)
        {
            case '+':
                Console.WriteLine(fristNumber + secondNumber);
                break;
            case  '-':
                Console.WriteLine(fristNumber - secondNumber);
                break;
            case '*':
                Console.WriteLine(fristNumber * secondNumber);
                break;
            case '/':
                if (secondNumber !=0)
                {
                    Console.WriteLine(fristNumber / secondNumber);
                }
                else
                {
                    Console.WriteLine("can not divide by zero");
                }
                break;
            case '%':
                if (secondNumber != 0)
                {
                    Console.WriteLine(fristNumber % secondNumber);
                }
                else
                {
                    Console.WriteLine("can not divide by zero");
                }
                break;
            default:
                Console.WriteLine("invalid operator");
                break;
        }
        
        ///// task 11///
        
        Console.WriteLine("Enter you Age:");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your monthly income:");
        int monthlyIncome = int.Parse(Console.ReadLine());
        Console.WriteLine("do you have existing loan (yes/no):");
        string loan = Console.ReadLine();
        bool existingLoan = (loan == "yes");
        
        if (age >= 21 && age <= 60 && monthlyIncome >= 400 && !existingLoan)
        {
            Console.WriteLine("You are eligible for the loan!");
        }
        else if (age < 21 || age > 60)
        {
            Console.WriteLine("Not eligible: Age out of range.");
        }
        else if (monthlyIncome < 400)
        {
            Console.WriteLine("Not eligible: Income too low.");
        }
        else if (existingLoan)
        {
            Console.WriteLine("Not eligible: You already have an existing loan.");
        }
    }
}