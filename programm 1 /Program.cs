namespace programm_1;

class Program
{
    /// Function task 1 //// 
    // public static void PrintWlecome(string name)
    // {
    //     Console.WriteLine("Welcome " + name );
    // }

    // function task 2 //
    public static int square(int n)
    {
        int sequarev = n * n;
        return sequarev;
    }

    static void Main(string[] args)
    {
        
        //// task 1 ////
        // Console.WriteLine("Enter your name:");
        // string name = Console.ReadLine();
        // PrintWlecome(name);
        
        //// task 2 ///
        
        Console.WriteLine("Enter a number:");
        int number= int.Parse(Console.ReadLine());
        int result = square(number);
        Console.WriteLine("the square is: "+result);
        
    }
    
     
     
        

    }
