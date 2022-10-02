using System;

namespace homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It is necessary to enter the number N, and N>0");
            try
            {
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
            }
            catch (Exception)
            {
                Console.WriteLine("End of the program");
                Environment.Exit(0);
            }
            Console.WriteLine();

        }
    }
}