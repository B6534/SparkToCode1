 Task-day-5
﻿using System.Reflection.Metadata;

﻿using System;
 main

namespace programm_1;

class Program
{
    static void Main(string[] args)
    {
Task-day-5
         // task 1 ///

          int[] grade = new int [5];
          for (int i = 0; i < grade.Length; i++)
          {
              Console.Write("Enter grade {0}: ", i + 1);
              grade[i] = int.Parse(Console.ReadLine());
          }
          Console.WriteLine("Student Grades:");
          foreach (int  g in grade)
          {
              Console.WriteLine("grade: " + g);
          }
         
         // task 2 //

          List<string>t odo = new List<string>();
          for (int i = 0; i < 5; i++)
          {
              Console.WriteLine("Enter your list what you want to do:" + (i+1));
              string add =  Console.ReadLine();
              to do.Add(add);
          } 
          Console.WriteLine("your list is :");
          foreach (string list in to do)
          {
              Console.WriteLine(list);
              
          }
         
         // task 3 //
          Stack<string> history = new Stack<string>();
          Console.WriteLine("Enter three website:");
          for ( int i=0; i<3; i++ )
          {
              Console.Write("Website URL: " + (i+1));
              string websiteURL = Console.ReadLine();
              history.Push(websiteURL);
          }
          if (history.Count == 0)
          {
              string remove = history.Pop();
              Console.WriteLine("back: " + remove);
          }
          if (history.Count > 0)
          {
              Console.WriteLine("You are now on: " + history.Peek());
          }
          else
          {
              Console.WriteLine("No more pages in history.");
          }
         
         // task 4 //
          Queue<string>  customers = new Queue<string>();
          for (int i = 0; i < 3; i++)
          {
              Console.WriteLine("Enter customer Name: " + (i+1));
              string customerName = Console.ReadLine();
              customers.Enqueue(customerName);
          }
         
          foreach (string waiting in customers)
          {
              Console.WriteLine(" wating list: " + wating);
              
          }
         
         // task 5 //
          int[] grades = new int[5];
          double sum = 0; 
          for (int i = 0; i < grades.Length; i++)
          {
              Console.Write("Enter grade " + (i + 1) );
              grades[i] = int.Parse(Console.ReadLine());
              sum += grades[i];
          }
          Array.Sort(grades);
          double average = sum/grades.Length;
          int lowest = grades[0];
          int highest = grades[grades.Length - 1];
         
          Console.WriteLine(" Grade Results ");
          Console.WriteLine("Sorted Grades: " + string.Join(", ", grades));
          Console.WriteLine("Lowest Grade: " + lowest);
          Console.WriteLine("Highest Grade: " + highest);
          Console.WriteLine("Average Grade: " + average);
         
         // task 6 //
         
          List<string> shoppingList = new List<string>();
          string input = "";
          Console.WriteLine("Enter items for your shopping list (type 'done' to finish):");
          while (input.ToLower() != "done")
          {
              Console.Write("Item: ");
              input = Console.ReadLine();
             
              if (input.ToLower() != "done")
              {
                  shoppingList.Add(input);
              }
          }
          Console.WriteLine("Initial Shopping List:");
          foreach (string item in shoppingList)
          {
              Console.WriteLine(item);
          }
          Console.Write("Enter an item name to remove: ");
          string itemToRemove = Console.ReadLine();
         
          if (shoppingList.Remove(itemToRemove))
          {
              Console.WriteLine(itemToRemove + " removed.");
          }
          else
          {
              Console.WriteLine("Item not found in the list.");
          }
          Console.WriteLine("Final Shopping List:");
          foreach (string item in shoppingList)
          {
              Console.WriteLine( item);
          }
         
         // task 7 //
         
          List<int> scores = new List<int>();
          Console.WriteLine("Enter 5 game scores:");
          for (int i = 0; i < 5; i++)
          {
              Console.Write("Score :"+ (i + 1));
              scores.Add(int.Parse(Console.ReadLine()));
          }
          scores.Reverse();
          Console.WriteLine("High Score Podium ");
          Console.WriteLine("1. place: " + scores[0]);
          Console.WriteLine("2. place: " + scores[1]);
          Console.WriteLine("3. place: " + scores[2]);
         
         // task 8 //
         
          Stack<string> actionHistory = new Stack<string>();
          string action = " ";
          Console.WriteLine("Enter editor actions (type 'stop' to finish):");
          while (true)
          {
              Console.Write("Action: ");
              action = Console.ReadLine();
         
              if (action.ToLower() == "stop")
              {
                  break;
              }
         
              actionHistory.Push(action);
          }
          Console.WriteLine("Undoing Last Two Actions");
          for (int i = 0; i < 2; i++)
          {
              if (actionHistory.Count > 0)
              {
                  string undoneAction = actionHistory.Pop();
                  Console.WriteLine("Undone: " + undoneAction);
              }
              else
              {
                  Console.WriteLine("Nothing left to undo.");
              }
          }
          Console.WriteLine("Remaining Actions in History: ");
          foreach (string remainingAction in actionHistory)
          {
              Console.WriteLine(remainingAction);
          }
         
         //// task 9 ///
         Console.Write("How many grades do you want to enter? ");
         int count = int.Parse(Console.ReadLine());
         List<int> grades = new List<int>();
         for (int i = 0; i < count; i++)
         {
             Console.Write("Enter grade :" + (i + 1));
             grades.Add(int.Parse(Console.ReadLine()));
         }

         double average = CalculateAverage(grades);
         int firstFailure = FindFirstFailing(grades);

         Console.WriteLine("Results : ");
         Console.WriteLine("Average grade: " + average);

         if (firstFailure != 0)
         {
             Console.WriteLine("First failing grade found: " + firstFailure);
         }
         else
         {
             Console.WriteLine("No failing grades found!");
         }
         
    }
    //// function task 9 ///
    public static double CalculateAverage(List<int> grades)
    {
        double sum = 0;
        foreach (int grade in grades)
        {
            sum += grade;
        }
        return sum/grades.Count;

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
            
 main
    }

    public static int FindFirstFailing(List<int> grades)
    {
        return grades.Find(g => g < 60);
    }
        


