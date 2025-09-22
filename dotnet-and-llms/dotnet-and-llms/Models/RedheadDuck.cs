using llms.Models.algorithms.implementations;
using System;

namespace llms.Models
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            quackBehaviour = new Quack();
            flyBehaviour = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("Looks like a Redhead Duck");
        }
    }
}
