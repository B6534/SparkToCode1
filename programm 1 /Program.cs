namespace programm_1;


class BankAccount 
{
    public int AccountNumber;
    public string HolderName;
    public double Balance;
    public BankAccount(int accNum, string name, double bal) { AccountNumber = accNum; HolderName = name; Balance = bal; }
    public void Deposit(double amount) { Balance += amount; SendEmail(); }
    public void Withdraw(double amount) { if (Balance >= amount) { Balance -= amount; SendEmail(); } }
    public double CheckBalance() { PrintInformation(); return Balance; }
    private void PrintInformation() => Console.WriteLine($"Holder: {HolderName}, Balance: {Balance}");
    private void SendEmail() => Console.WriteLine("Notification sent.");
}

class Student 
{
    public string Name;
    public string Address;
    public int Grade;
    private string email; // Add this field declaration!

    public void Register(string email) 
    {
        this.email = email;
        SendEmail();
    }
    private void SendEmail() => Console.WriteLine("Registration email sent.");
}

class Product {
    public string ProductName;
    public double Price;
    public int StockQuantity;
    public double GetInventoryValue() 
    { 
        PrintDetails(); 
        return Price * StockQuantity; 
    }
    private void PrintDetails() => Console.WriteLine($"{ProductName}, Price: {Price}, Stock: {StockQuantity}");
}

class Program
{
    static BankAccount b1 = new BankAccount(1163, "karim", 120);
    static BankAccount b2 = new BankAccount(15203, "Ali", 63);
    static Student s1 = new Student { Name = "Ali", Address = "Muscat", Grade = 65 };
    static Student s2 = new Student { Name = "Ahmed", Address = "Muscat", Grade = 70 };
    static Product p1 = new Product { ProductName = "Wireless Mouse", Price = 5.500, StockQuantity = 50 };
    static Product p2 = new Product { ProductName = "Mechanical Keyboard", Price = 15.750, StockQuantity = 20 };

    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\n--- Menu (1-5, 20 to Exit) ---");
            string choice = Console.ReadLine();

            switch (choice)
            { 
                
                case "1":
                    PickAccount().CheckBalance();
                    break;
                
                case "2": 
                    Student s = PickStudent();
                    Console.Write("Enter new address: ");
                    s.Address = Console.ReadLine();
                    break;
                
                case "3": 
                    BankAccount b = PickAccount();
                    Console.Write("Amount: ");
                    b.Deposit(double.Parse(Console.ReadLine()));
                    break;
                
                case "4": 
                    BankAccount bW = PickAccount();
                    Console.Write("Amount: ");
                    bW.Withdraw(double.Parse(Console.ReadLine()));
                    break;
                
                case "5": 
                    Console.WriteLine("Total Value: " + PickProduct().GetInventoryValue());
                    break;
                // Register  Student
                case "6":
                    Student regStudent = PickStudent();
                    Console.Write("Enter email: ");
                    string email = Console.ReadLine();
                    regStudent.Register(email);
                    Console.WriteLine("Student registered successfully.");
                    break;
                
                // Compare Account Balances
                case "7":
                    if (b1.Balance > b2.Balance)
                        Console.WriteLine($"{b1.HolderName} has more money: {b1.Balance}");
                    else if (b2.Balance > b1.Balance)
                        Console.WriteLine($"{b2.HolderName} has more money: {b2.Balance}");
                    else
                        Console.WriteLine("Both accounts have an equal balance.");
                    break;
                
                case "20": running = false; 
                    break;
            }
        }
    }
    
    static BankAccount PickAccount() { Console.Write("Pick (1: Karim, 2: Ali): "); return (Console.ReadLine() == "1") ? b1 : b2; }
    static Student PickStudent() { Console.Write("Pick (1: Ali, 2: Ahmed): "); return (Console.ReadLine() == "1") ? s1 : s2; }
    static Product PickProduct() { Console.Write("Pick (1: Mouse, 2: Keyboard): "); return (Console.ReadLine() == "1") ? p1 : p2; }
}