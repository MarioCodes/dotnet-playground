using llms.Models.algorithms.interfaces;
using System;

namespace llms.Models.algorithms.implementations
{
    public class Squeak : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Squeaks like a rubber duck");
        }

    }
}
