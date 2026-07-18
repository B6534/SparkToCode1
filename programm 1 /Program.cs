namespace programm_1;

class Program
{
    class BankAccount {
    public int AccountNumber;
    public string HolderName;
    public double Balance;
    // Research Case 18: Read-Only Property
    public bool IsOverdrawn => Balance < 0;

    // Research Case 16: Parameterized Constructor
    public BankAccount(int accNum, string name, double bal) {
        AccountNumber = accNum; HolderName = name; Balance = bal;
    }

    public void Deposit(double amount) {
        Balance += amount;
        SendEmail();
    }

    public void Withdraw(double amount) {
        if (Balance >= amount) {
            Balance -= amount;
            SendEmail();
        }
    }

    public double CheckBalance() {
        PrintInformation();
        return Balance;
    }

    private void PrintInformation() => Console.WriteLine($"Holder: {HolderName}, Balance: {Balance}");
    private void SendEmail() => Console.WriteLine("Notification sent.");
}

class Student {
    public int Grade;
    public string Name;
    public string Address;
    private string email; 
    int age; 

    
    public static int StudentCount = 0;
    public Student() { StudentCount++; }
    public static int GetStudentCount() => StudentCount;
    
    private int pin;
    public int SecurityPin { set { pin = value; } }

    public void Register(string email) {
        this.email = email;
        SendEmail();
    }
    private void SendEmail() => Console.WriteLine("Registration email sent.");
}

class Product {
    public string ProductName;
    public double Price;
    public int StockQuantity;

    public void Sell(int quantity) {
        if (StockQuantity >= quantity) { StockQuantity -= quantity; LogTransaction(); }
        else Console.WriteLine("Not enough stock.");
    }
    public void Restock(int quantity) { StockQuantity += quantity; LogTransaction(); }
    public double GetInventoryValue() { PrintDetails(); return Price * StockQuantity; }
    private void PrintDetails() => Console.WriteLine($"{ProductName}, Price: {Price}, Stock: {StockQuantity}");
    private void LogTransaction() => Console.WriteLine("Transaction logged.");
}
    
    
    static void Main(string[] args)
    {
        static BankAccount b1 = new BankAccount(1163, "karim", 120);
        static BankAccount b2 = new BankAccount(15203, "Ali", 63);

        
        
        
        }
        

    }
