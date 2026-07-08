using System.Reflection.Metadata;

namespace programm_1;

class Program
{
    static void Main(string[] args)
    {
         //// task 1 ///

         // int[] grade = new int [5];
         // for (int i = 0; i < grade.Length; i++)
         // {
         //     Console.Write("Enter grade {0}: ", i + 1);
         //     grade[i] = int.Parse(Console.ReadLine());
         // }
         // Console.WriteLine("Student Grades:");
         // foreach (int  g in grade)
         // {
         //     Console.WriteLine("grade: " + g);
         // }
         
         //// task 2 //

         // List<string>t odo = new List<string>();
         // for (int i = 0; i < 5; i++)
         // {
         //     Console.WriteLine("Enter your list what you want to do:" + (i+1));
         //     string add =  Console.ReadLine();
         //     to do.Add(add);
         // } 
         // Console.WriteLine("your list is :");
         // foreach (string list in to do)
         // {
         //     Console.WriteLine(list);
         //     
         // }
         
         //// task 3 //
         // Stack<string> history = new Stack<string>();
         // Console.WriteLine("Enter three website:");
         // for ( int i=0; i<3; i++ )
         // {
         //     Console.Write("Website URL: " + (i+1));
         //     string websiteURL = Console.ReadLine();
         //     history.Push(websiteURL);
         // }
         // if (history.Count == 0)
         // {
         //     string remove = history.Pop();
         //     Console.WriteLine("back: " + remove);
         // }
         // if (history.Count > 0)
         // {
         //     Console.WriteLine("You are now on: " + history.Peek());
         // }
         // else
         // {
         //     Console.WriteLine("No more pages in history.");
         // }
         
         //// task 4 //
         Queue<string>  customers = new Queue<string>();
         for (int i = 0; i < 3; i++)
         {
             Console.WriteLine("Enter customer Name: " + (i+1));
             string customerName = Console.ReadLine();
             customers.Enqueue(customerName);
         }

         foreach (string wating in customers)
         {
             Console.WriteLine(" wating list: " + wating);
             
         }




    }
}