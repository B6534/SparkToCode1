namespace programm_1;

class Program
{

    static void Main(string[] args)
    {
        
        // task 1 ////
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        PrintWlecome(name);
        
    }
    
    /// Function task 1 //// 
     public static void PrintWlecome(string name)
     {
         Console.WriteLine("Welcome " + name );
     }
        

    }
