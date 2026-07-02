namespace SessionTwoTasks
{
    class Program
    {
        static void Main(string[] args)
        {
         ///// Task 1 ///
         
         Console.WriteLine("Enter number");
         int number = int.Parse(Console.ReadLine());
         for ( int i= number ; i>0; i--)
         {
             Console.WriteLine(i);
         }
         Console.WriteLine("Liftoff!");
        }
    }
}