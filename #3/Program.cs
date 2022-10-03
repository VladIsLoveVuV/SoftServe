using System;
namespace homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You must enter A and B, and A<B");
                Console.WriteLine("Enter A");
                int A = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter B");
                int B = Convert.ToInt16(Console.ReadLine());
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
            Console.WriteLine("End of program");
        }
    }
}