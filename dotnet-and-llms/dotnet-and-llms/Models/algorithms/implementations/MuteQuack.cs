using llms.Models.algorithms.interfaces;
using System;

namespace llms.Models.algorithms.implementations
{
    public class MuteQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("<<Silence>>");
        }

    }
}
