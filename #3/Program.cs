using System;

namespace homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You must enter A and B, and A<B");
            try
            {
                Console.WriteLine("Enter A");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter B");
                int B = Convert.ToInt32(Console.ReadLine());
                if (A >= B || A <= 0 || B <= 0)
                {
                    Console.WriteLine("The condition A<B is not met or the numbers A and B are not positive");
                    return;
                }
                Console.Clear();
                for (int i = A; i <= B; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(i);
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("End of the program");
                Environment.Exit(0);
            }
        }
    }
}