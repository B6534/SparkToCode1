using System.ComponentModel.Design;

namespace programm_1;

class Program
{
    ///// Function task 1 //// 
    // public static void PrintWlecome(string name)
    // {
    //     Console.WriteLine("Welcome " + name );
    // }

    //// function task 2 //
    // public static int square(int n)
    // {
    //     int sequarev = n * n;
    //     return sequarev;
    // }


    ////Funtcion task 3 /// 
    // public static double celesiustofahrndheit(double c)
    // {
    //     double f = (c * 9 / 5) + 32;
    //     return f; 
    // }

    ////Function task 4 ///
    // public static void displaymenu()
    // {
    //     Console.WriteLine("Please select an option");
    //     Console.WriteLine("1. start");
    //     Console.WriteLine("2. help");
    //     Console.WriteLine("3. exit");
    // }

    // Function task 5 //
    // public static bool iEven(int n )
    // {
    //     return (n % 2 == 0);
    // }

    //// Function task 6 //
    // public static double area(double x, double y)
    // {
    //     return x * y;
    // }
    //
    // public static double perimeter(double x, double y)
    // {
    //     return 2+ (x * y);
    // }

    ////Function 7 //
    // public static string GetGradeLetter(int g)
    // {
    //     if (g >= 90)
    //     {
    //         return "A";
    //     }
    //     else if (g >=80)
    //     {
    //          return "B";
    //     } 
    //     else if (g>=70)
    //     {
    //        return "C";
    //     }
    //     else if (g >=60)
    //     {
    //         return "D";
    //     }
    //     else
    //     {
    //         return "E";
    //     }
    //     
    // }
    
    ////Function task 8 //
    // public static void Countdown(int c)
    // {
    //     for (int i = c; i >= 1; i--)
    //     {
    //         Console.WriteLine(i);
    //     }
    //     Console.WriteLine("done");
    // }
    
    ////Funtion task 9 //
    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static int Multiply(int a, int b, int c)
    {
        return a * b * c;
    }
    static void Main(string[] args)
    {
        
        //// task 1 ////
        // Console.WriteLine("Enter your name:");
        // string name = Console.ReadLine();
        // PrintWlecome(name);
        
        //// task 2 ///
        
        // Console.WriteLine("Enter a number:");
        // int number= int.Parse(Console.ReadLine());
        // int result = square(number);
        // Console.WriteLine("the square is: "+result);
        
        //// task 3 ///
        // Console.WriteLine("Enter temperature in Celsius:");
        // double celsius = double.Parse(Console.ReadLine());
        // double fahrenheit = celesiustofahrndheit(celsius);
        // Console.WriteLine("temperature  in fihernhit is: " + fahrenheit);
        
        //// task 4 ////
        
        // displaymenu();
        
        // task 5 // 
        // Console.WriteLine("Enter a number");
        // int number= int.Parse(Console.ReadLine());
        // bool ieven = iEven(number);
        // if (ieven)
        // {
        //     Console.WriteLine("Even");
        //     
        // }
        // else
        // {
        //     Console.WriteLine("Odd");
        // }
        
        //// task 6 // 
        // Console.Write("Enter Length: ");
        // double length = double.Parse(Console.ReadLine());
        // Console.Write("Enter Width: ");
        // double width = double.Parse(Console.ReadLine());
        // Console.WriteLine("Area is : " + area(length, width));
        // Console.WriteLine("Perimeter is : " + perimeter(length, width));
        
        //// task 7 // /
        // Console.Write("Enter a grade: ");
        // int g = int.Parse(Console.ReadLine());
        // string gradeLetter = GetGradeLetter(g);
        // Console.WriteLine("yor grade is:"+gradeLetter);
        
        ///// task 8////
        // Console.Write("Enter a stsring number: ");
        // int s = int.Parse(Console.ReadLine());
        // Countdown(s);
        
        //// task 9 ///
        int m1 = Multiply(4, 5);
        double m2 = Multiply(4.2, 5.5);
        int m3 = Multiply(4, 5,9);
        Console.WriteLine("tow int: "+m1);
        Console.WriteLine("tow double: "+m2);
        Console.WriteLine("three int : "+m3);


    }
    
     
     
        

    }
