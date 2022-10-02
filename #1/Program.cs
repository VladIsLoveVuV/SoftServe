using System;

namespace homework1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Press the dot to end the program");
            Console.WriteLine("Enter some symbols: ");

            char input;
            int spaceCount = 0;
            do
            {
                input = Console.ReadKey().KeyChar;
                if (input == ' ')
                    spaceCount++;
            }
            while (input != '.');

            Console.WriteLine("Quantity of spaces: " + spaceCount);

        }
    }
}
