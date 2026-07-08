namespace programm_1;

class Program
{
    static void Main(string[] args)
    {
         //// task 1 ///

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
         


    }
}