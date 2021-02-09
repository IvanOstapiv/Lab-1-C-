using System;

namespace My_project
{
    public class Program
    {
        static public int Lab(int a, int b = 60)
        {
            int c = a / b;
            Console.WriteLine(a.ToString() + " / " + b + " = " + c.ToString());
            return c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть кількість секунд");
            string S1 = Console.ReadLine();
            int a = int.Parse(S1);
            Lab(a);
            Console.ReadLine();
        }
    }
}
