using System;

namespace programm_1;

class Program
{
    static void Main(string[] args)
    {
        task 1 ////
          try
          {
              Console.WriteLine("Enter first number:");
              float firstNumber = float.Parse(Console.ReadLine());
              
              Console.WriteLine("Ener second number:");
              float secondNumber = float.Parse(Console.ReadLine());
              
              double result = Math.Abs(secondNumber - firstNumber);
              Console.WriteLine(result);
          }
          catch (Exception )
          {
              Console.WriteLine("error: please type valid number only ");
          }
        
         // Task 2 // 
        
         Console.WriteLine("Enter a number:");
         float number = float.Parse(Console.ReadLine());
         double result = Math.Sqrt(number);
         double result2 = Math.Pow(number, 2);
         Console.WriteLine("Squared root: "+ result);
         Console.WriteLine("squard: " + result2);
        
         // Task 3 // 
        
         Console.WriteLine("Enter your full name:");
         string fullName = Console.ReadLine();
         int length = fullName.Length;
         string upper = fullName.ToUpper();
         string lower = fullName.ToLower();
         Console.WriteLine(lower);
         Console.WriteLine(upper);
         Console.WriteLine(length);
        
        // Task 4 //
        
        Console.WriteLine("Enter the number of days of a free trial:");
        int date = int.Parse(Console.ReadLine());
        DateTime today = DateTime.Today;
        DateTime today2 = today.AddDays(date);
        Console.WriteLine("Your subscription starts from: " + today.ToString("yyyy-MM-dd"));
        Console.WriteLine("Your subscription ends on: " + today2.ToString("yyyy-MM-dd"));
        
        Task 5 //
        
        Console.WriteLine("Enter your raw exam score:");
        double score = double.Parse(Console.ReadLine());
        double score2 = Math.Round(score , 0);
        if (score2 >= 60)
        {
            Console.WriteLine("Round score: " + score2);
            Console.WriteLine("Pass");
            
        }
        else  
        {
            Console.WriteLine("Round score: " + score2);
            Console.WriteLine("Fail");
        }
        
        task 6 // 
        Console.WriteLine("Enter your password:");
        string password = Console.ReadLine();
        bool longpassword = password.Length >= 8;
        bool notforbidden = !password.ToLower().Contains("password");
        
        if (longpassword && notforbidden)
        {
            Console.WriteLine("Strong: Your password is valid.");
        }
        else
        {
            Console.WriteLine("Weak: Password must be at least 8 characters.");
        }
        
        Task 7 //
        Console.WriteLine("Enter your first name");
        string fName = Console.ReadLine();
        Console.WriteLine("Enter your socond name");
        string sName = Console.ReadLine();
        string cleanname = fName.Trim().ToLower();
        string cleanname2 = sName.Trim().ToLower();
        if (cleanname == cleanname2)
        {
            Console.WriteLine("Match name");
        }
        else
        {
            Console.WriteLine("No match name");
        }
        
        task 8 // 
        
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
        
        Task 9 //
        Console.WriteLine("Enter decimal number");
        double number = double.Parse(Console.ReadLine());
        double nearst = Math.Round(number);
        double roundup = Math.Ceiling(nearst);
        double rounddown = Math.Floor(nearst);
        Console.WriteLine("Number: " + number);
        Console.WriteLine("Round to nearst: " + nearst);
        Console.WriteLine("Round up: " + roundup);
        Console.WriteLine("Round down: " + rounddown);
       
        Task 10 // 
        
        Console.WriteLine("Ener full sentence: ");
        string sentence = Console.ReadLine();
        Console.WriteLine("Enter word to search for: ");
        string word = Console.ReadLine();
        
        int firstindex = sentence.IndexOf(word);
        int secondindex = sentence.LastIndexOf(word);
        if (firstindex == -1)
        {
            Console.WriteLine("The word '" + word + "' was not found in the sentence.");
            
        }
        else
        {
            Console.WriteLine("First position: " + firstindex);
            Console.WriteLine("Second position: " + secondindex);
        }
        
        Task 11 // 
        Random rnd = new Random();
        int otp = rnd.Next(1000, 10000);
        Console.WriteLine("Your OTP is: " + otp);
        Console.Write("Please enter the code : ");
        bool isvervalid =  false;
        for (int i=1 ; i>=3 ; i++)
        {
            try
            {
              int input = int.Parse(Console.ReadLine());
              if (input == otp)
              {
                  
                  Console.WriteLine("Verified "); 
                  isvervalid = true;
                  break;
              }
              else
              {
                  Console.WriteLine("Invalid : incorrect code");
              }
            }
            
            catch (Exception )
            {
                Console.WriteLine("invalid input please enter nunbers only");
            }
        
        
        
        // Task 12 // 
        
        Console.WriteLine("Enter you birth day (yyyy-MM-dd)");
        string birthDay = Console.ReadLine();
        if (DateTime.TryParse(birthDay, out DateTime dob))
        {
            DateTime today = DateTime.Today;
                int age= today.Year - dob.Year;
                if (today.Month < dob.Month || (today.Month == dob.Month && today.Day < dob.Day))
                {
                    age--;
                }
                DayOfWeek birthDayOfWeek = dob.DayOfWeek;
                Console.WriteLine("Your age is: " + age);
                Console.WriteLine("You were born on a: " + birthDayOfWeek);
        }
        else
        {
            Console.WriteLine("Invalid date format. Please use yyyy-MM-dd.");
        }
            
    }

    }
        


