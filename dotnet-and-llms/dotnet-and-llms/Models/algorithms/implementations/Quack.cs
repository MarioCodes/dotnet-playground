using llms.Models.algorithms.interfaces;
using System;

namespace llms.Models.algorithms.implementations
{
    public class Quack : IQuackBehaviour
    {
        void IQuackBehaviour.Quack()
        {
            Console.WriteLine("quacks like a duck");
        }

    }
}
