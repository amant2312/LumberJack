using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumberJack
{
    class LumberJack
    {
        public string Name { get; private set; }

        private Stack<Flapjack> flapjacks = new Stack<Flapjack>();

        public LumberJack(string name) 
        {
            Name = name;
        }

        public void TakeFlapjack(Flapjack flapjack)
        {
            flapjacks.Push(flapjack);
        }

        public void EatFlapjack()
        {
            Console.WriteLine($"{Name} is eating flapjacks");
            while (flapjacks.Count>0)
            {
                Console.WriteLine($"{Name} ate a {flapjacks.Pop().ToString()} flapjack");
            }
        }
    }
}
