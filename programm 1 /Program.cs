namespace SessionTwoTasks
{
    class Program
    {
        static void Main(string[] args)
        {
         ///// Task 1 ///
         
         // Console.WriteLine("Enter number");
         // int number = int.Parse(Console.ReadLine());
         // for ( int i= number ; i>0; i--)
         // {
         //     Console.WriteLine(i);
         // }
         // Console.WriteLine("Liftoff!");
         
         /// Task 2 ////
         
         Console.WriteLine("Enter Positive Number");
         int numbe= int.Parse(Console.ReadLine());
         int sum = 0;
         for (int i = 1; i <= numbe; i++)
         {
            sum += i;
         }
         Console.WriteLine("fnal result: " + sum);
             
          
         
        }
    }
}