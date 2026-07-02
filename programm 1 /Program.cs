namespace SessionTwoTasks
{
    class Program
    {
        static void Main(string[] args)
        {
         ///// Task 1 ///
         
         // Console.WriteLine("Enter number");
         // int number = int.Parse(Console.ReadLine());
         // for ( int i= number ; i>0; i--)
         // {
         //     Console.WriteLine(i);
         // }
         // Console.WriteLine("Liftoff!");
         
         /// Task 2 ////
         
         // Console.WriteLine("Enter Positive Number");
         // int numbe= int.Parse(Console.ReadLine());
         // int sum = 0;
         // for (int i = 1; i <= numbe; i++)
         // {
         //    sum += i;
         // }
         // Console.WriteLine("fnal result: " + sum);
             
          //// task 3 ////
         // Console.WriteLine("Enter Number");
         // int number = int.Parse(Console.ReadLine());
         // int result = 0;
         // for (int i = 1; i <= 10; i++)
         // {
         //      result = number * i;
         //     Console.WriteLine(number + " x " + i + " = " + result);
         // }
         
         
         ///// task 4 ////

         // string password = " ";
         // Console.WriteLine("Please enter your password: ");
         // while (password != "Spark2026") 
         // {
         //     password = Console.ReadLine();
         //     if (password != "Spark2026")
         //     {
         //         Console.WriteLine("Incorrect password try again"); 
         //     }
         //     
         // }
         // Console.WriteLine("Access Granted ");
         
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
         




        }
    }
}