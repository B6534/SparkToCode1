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
    //// function task 9 ////
    public static double CalculateAverage(List<int> grades)
    {
        double sum = 0;
        foreach (int grade in grades)
        {
            sum += grade;
        }
        return sum/grades.Count;

        
    }

    public static int FindFirstFailing(List<int> grades)
    {
        return grades.Find(g => g < 60);
    }
        


