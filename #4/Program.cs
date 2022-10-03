using System;
namespace homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It is necessary to enter the number N, and N>0");            
                Console.WriteLine("Enter N");
                string N = Console.ReadLine();
                if (Convert.ToInt32(N) < 0)
                {
                    Console.WriteLine("Condition N>0 not met");
                    return;
                }
                Console.Clear();
                Console.WriteLine("Received number");
                for (int i = N.Length - 1; i >= 0; i--)
                {
                    Console.Write(N[i]);
                }            
            Console.WriteLine("\nEnd of program");
        }
    }
}