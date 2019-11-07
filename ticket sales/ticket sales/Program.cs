using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticket_sales
{
    class Program
    {

        const int DISCOUNT_AGE = 18;
        const int TICKETS_REMAINING_CUTOFF = 100;
        static void Main(string[] args)
        {
            int age = 25;
            int ticketsRemaining = 150;

            if (age < DISCOUNT_AGE)
            {
                Console.WriteLine("You are young enough to get a discount");
                Console.ReadLine();
                if (ticketsRemaining > TICKETS_REMAINING_CUTOFF)
                {
                    Console.WriteLine("You get a discount");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("But there are not enough tickets left,");
                    Console.WriteLine("So you must pay full price");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Being{0} or older,you don't get a discount.", DISCOUNT_AGE);
                Console.ReadLine();
            }
            Console.WriteLine("This line always happens.");
            Console.ReadLine();
        }
    }
}
