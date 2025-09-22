using llms.Models.algorithms.implementations;
using llms.Models.algorithms.interfaces;
using System;

namespace llms.Models
{
    public class MallardDuck : Duck
    {
        public MallardDuck(IQuackBehaviour quack,
            IFlyBehaviour fly)
        {
            quackBehaviour = quack;
            flyBehaviour = fly;
        }

        public override void Display()
        {
            Console.WriteLine("Looks like a Mallard Duck");
        }
    }
}
