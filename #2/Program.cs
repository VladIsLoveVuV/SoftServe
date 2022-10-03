using System;
namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 6 digit ticket");
                string ticket = Console.ReadLine();
                int tickets = Convert.ToInt32(ticket);
                Console.WriteLine((Convert.ToInt32(Convert.ToString(ticket)[0].ToString()) +
                                   Convert.ToInt32(Convert.ToString(ticket)[1].ToString()) +
                                   Convert.ToInt32(Convert.ToString(ticket)[2].ToString())) ==
                                  (Convert.ToInt32(Convert.ToString(ticket)[3].ToString()) +
                                   Convert.ToInt32(Convert.ToString(ticket)[4].ToString()) +
                                   Convert.ToInt32(Convert.ToString(ticket)[5].ToString()))
                    ? "Ticket happy"
                    : "The ticket is not happy");
        }
    }
}