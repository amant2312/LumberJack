using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumberJack
{
    internal class Program
    {
        static Random random = new Random();  
        static void Main(string[] args)
        {
            Queue<LumberJack> lumberJacks = new Queue<LumberJack>();

            while (true)
            {
                Console.WriteLine("Enter first name");
                string name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }
                LumberJack l1 = new LumberJack(name);
                Console.WriteLine("Enter number of Flapjacks");
                int.TryParse(Console.ReadLine(), out int number);

                while (number > 0)
                {
                    l1.TakeFlapjack((Flapjack)random.Next(4));
                    number--;
                }
                lumberJacks.Enqueue(l1);



            }

            while(lumberJacks.Count>0)
            {
                LumberJack lumberJack=lumberJacks.Dequeue();
                lumberJack.EatFlapjack();
                
            }
            Console.ReadLine();
           


        }
    }
}
