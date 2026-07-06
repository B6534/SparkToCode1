using System;

namespace programm_1;

class Program
{
    static void Main(string[] args)
    {
        // task 1 ////
        //   try
        //   {
        //       Console.WriteLine("Enter first number:");
        //       float firstNumber = float.Parse(Console.ReadLine());
        //       
        //       Console.WriteLine("Ener second number:");
        //       float secondNumber = float.Parse(Console.ReadLine());
        //       
        //       double result = Math.Abs(secondNumber - firstNumber);
        //       Console.WriteLine(result);
        //   }
        //   catch (Exception )
        //   {
        //       Console.WriteLine("error: please type valid number only ");
        //   }
        //
        //  // Task 2 // 
        //
        //  Console.WriteLine("Enter a number:");
        //  float number = float.Parse(Console.ReadLine());
        //  double result = Math.Sqrt(number);
        //  double result2 = Math.Pow(number, 2);
        //  Console.WriteLine("Squared root: "+ result);
        //  Console.WriteLine("squard: " + result2);
        //
        //  // Task 3 // 
        //
        //  Console.WriteLine("Enter your full name:");
        //  string fullName = Console.ReadLine();
        //  int length = fullName.Length;
        //  string upper = fullName.ToUpper();
        //  string lower = fullName.ToLower();
        //  Console.WriteLine(lower);
        //  Console.WriteLine(upper);
        //  Console.WriteLine(length);
        //
        // // Task 4 //
        //
        // Console.WriteLine("Enter the number of days of a free trial:");
        // int date = int.Parse(Console.ReadLine());
        // DateTime today = DateTime.Today;
        // DateTime today2 = today.AddDays(date);
        // Console.WriteLine("Your subscription starts from: " + today.ToString("yyyy-MM-dd"));
        // Console.WriteLine("Your subscription ends on: " + today2.ToString("yyyy-MM-dd"));
        
        // Task 5 //
        
        // Console.WriteLine("Enter your raw exam score:");
        // double score = double.Parse(Console.ReadLine());
        // double score2 = Math.Round(score , 0);
        // if (score2 >= 60)
        // {
        //     Console.WriteLine("Round score: " + score2);
        //     Console.WriteLine("Pass");
        //     
        // }
        // else  
        // {
        //     Console.WriteLine("Round score: " + score2);
        //     Console.WriteLine("Fail");
        // }
        
        // task 6 // 
        // Console.WriteLine("Enter your password:");
        // string password = Console.ReadLine();
        // bool longpassword = password.Length >= 8;
        // bool notforbidden = !password.ToLower().Contains("password");
        //
        // if (longpassword && notforbidden)
        // {
        //     Console.WriteLine("Strong: Your password is valid.");
        // }
        // else
        // {
        //     Console.WriteLine("Weak: Password must be at least 8 characters.");
        // }
        
        // Task 7 //
        // Console.WriteLine("Enter your first name");
        // string fName = Console.ReadLine();
        // Console.WriteLine("Enter your socond name");
        // string sName = Console.ReadLine();
        // string cleanname = fName.Trim().ToLower();
        // string cleanname2 = sName.Trim().ToLower();
        // if (cleanname == cleanname2)
        // {
        //     Console.WriteLine("Match name");
        // }
        // else
        // {
        //     Console.WriteLine("No match name");
        // }
        
        // task 8 // 
        
        Console.WriteLine("Enter membership start date (yyyy-MM-dd) ");
        string itstartDate = Console.ReadLine();
        Console.WriteLine("Enter the number of valid memberships days: ");
        int days = int.Parse(Console.ReadLine());
        if (DateTime.TryParse(itstartDate, out DateTime startDate))
        {
            DateTime expireDate = startDate.AddDays(days);
            if (expireDate >= DateTime.Today)
            {
                Console.WriteLine("Active membership");
            }
            else
            {
                Console.WriteLine("Inactive membership");
            }
            Console.WriteLine("Expiry Date: " + expireDate.ToString("yyyy-MM-dd"));
        }
        else
        {
            Console.WriteLine("Invalid date format. Please use yyyy-mm-dd.");
        }
            






    }
        

    }
