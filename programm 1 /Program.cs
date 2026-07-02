namespace SessionTwoTasks
{
    class Program
    {
        static void Main(string[] args)
        {
         ///// Task 1 ///
         
         Console.WriteLine("Enter number");
         int number = int.Parse(Console.ReadLine());
         for ( int i= number ; i>0; i--)
         {
             Console.WriteLine(i);
         }
         Console.WriteLine("Liftoff!");
         
         /// Task 2 ////
         
          Console.WriteLine("Enter Positive Number");
          int numbe= int.Parse(Console.ReadLine());
          int sum = 0;
          for (int i = 1; i <= numbe; i++)
          {
             sum += i;
          }
          Console.WriteLine("fnal result: " + sum);
             
          // task 3 ////
          Console.WriteLine("Enter Number");
          int number = int.Parse(Console.ReadLine());
          int result = 0;
          for (int i = 1; i <= 10; i++)
          {
               result = number * i;
              Console.WriteLine(number + " x " + i + " = " + result);
          }
         
         
         ///// task 4 ////

         string password = " ";
         Console.WriteLine("Please enter your password: ");
         while (password != "Spark2026") 
         {
             password = Console.ReadLine();
             if (password != "Spark2026")
             {
                 Console.WriteLine("Incorrect password try again"); 
             }
             
         }
         Console.WriteLine("Access Granted ");
         
         ////// tssk 5 ////
         int secnumber = 42;
         int guess = 0;
         int attempts = 0;
         Console.WriteLine("Guess the secret number");
         do
         {
             Console.WriteLine("Enter you Guess: ");
             guess = int.Parse(Console.ReadLine());
             attempts++;
             if (guess > secnumber)
             {
                 Console.WriteLine("Too high");
             }
             else if (guess < secnumber) 
             {
                 Console.WriteLine("Too low");
             }
             else
             {
                 Console.WriteLine("Correct it took you "+attempts);
             }
         } while ( guess != secnumber);
         
         //// task 6  //////
           try
           {
               Console.WriteLine("Enter first number:");
               int firstNumber = int.Parse(Console.ReadLine());
               
               Console.WriteLine("Enter second number:");
               int secondNumber = int.Parse(Console.ReadLine());
               
               float division = firstNumber / secondNumber; 
               Console.WriteLine("The division is: " + division);
           }
           catch (DivideByZeroException)
           {
               Console.WriteLine("Error: you cannot divide by zero");
               
           }
           catch (FormatException)
           {
               Console.WriteLine("Error: valid number.");
           }
           
           //// task 7 ///
           
           bool exit = false;
           while (exit)
           {
               Console.WriteLine("menu-driven program");
               Console.WriteLine("1) say hello ");
               Console.WriteLine("2) show current Time of day");
               Console.WriteLine("3) exit");
               try 
               {
                   int choice = int.Parse(Console.ReadLine());
                   switch  (choice)
                   {
                       case 1:
                           Console.WriteLine("Hello");
                           break;
                       case 2:
                           Console.WriteLine("Good morning");
                           break;
                       case 3:
                           Console.WriteLine("Exit");
                           exit = true;
                           break;
                       default:
                           Console.WriteLine(" Error: Not a valid option");
                           break;
                   }
               }
               catch (FormatException)
               {
                   Console.WriteLine(" Error: Not a valid option");
               }
           }
           
           /// task 8 ////
           
            Console.WriteLine("Enter number");
            int n= int.Parse(Console.ReadLine());
            float sum=0;
            for (int i= 1 ;  i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum+=i;
                    
                }
               
            }
            Console.WriteLine("the sum is :" + sum);
           
           ///// task 9 ///
           
           bool valid= false;
           int number = 0;
           do 
           {
               try
               {
                   Console.Write("Enter a number: ");
                   number = int.Parse(Console.ReadLine());
                   
                    if (number > 0)
                    {
                        valid = true;
                    }
               }
               catch (Exception )
               {
                   Console.WriteLine("error");
                   
               }    
           } while(!valid);
           
           ///// task 10 ////

           decimal = 10000;
           int pin = 1222;
           bool authorized =  false;

           for (int attempt = 1; attempt <=; attempt++)
           {
               
           }if (authorized)
           {
               while (true)
               {
                   
               }
           }
           









        }
    }
}