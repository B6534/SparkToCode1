namespace programm_1;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, SparkToCode!");
        //
        // Console.WriteLine("Please enter your Name: ");
        // string userName =  Console.ReadLine();
        //
        // Console.Write("Enter your Age: ");
        // int uaerage = int.Parse(Console.ReadLine());
        //
        // Console.WriteLine("Please enter your salary: ");
        // float usersalary = float.Parse(Console.ReadLine());
        //
        // Console.WriteLine("hello "+userName);
        // Console.WriteLine("You are "+uaerage);
        // Console.WriteLine("Your salary: "+usersalary);
        
        Console.WriteLine("Enter first Number: ");
        float firstNumber = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter second Number: ");
        float secondNumber = float.Parse(Console.ReadLine());
        
        float addresult = firstNumber + secondNumber;
        Console.WriteLine("Addtion:" + addresult);
        
        float Subtractresult = firstNumber - secondNumber;
        Console.WriteLine("Subtract: " + Subtractresult);

        float Multiplicationresult = firstNumber * secondNumber;
        Console.WriteLine("Multiplication: " + Multiplicationresult);
        
        float Divisionresult = firstNumber / secondNumber;
        Console.WriteLine("Division:" + Divisionresult);
        
        // and &&
        // or ||
        // not ! 

        Console.WriteLine("Enter First digree: ");
        float digree = float.Parse(Console.ReadLine());

        if (digree < 50)
        {
            Console.WriteLine("YOU failed ");
        }
        else if (digree > 50 && digree < 100) ;

        {
            Console.WriteLine("YOU pass ");
        }
///////////////////////////allll////////////////////////////////////////12
/// 
        Console.WriteLine("Welcome to main menu:");
        Console.WriteLine("1.Deposited");
        Console.WriteLine("2.withdraw");
        Console.WriteLine("3.blance chack ");
        
        Console.WriteLine("please choose an option: ");
        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1: 
                Console.WriteLine("deposited");
                break;
            case 2:
                Consolf.WriteLine("withdraw");
                erhgaoeihfgjoae
                break;
            case 3:
                Console.WriteLine("divided");
                break;
            default:
                Console.WriteLine("Not a valid option");
                break;
        }
        

    }
}