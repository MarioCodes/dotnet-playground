using llms.Models.algorithms.interfaces;
using System;

namespace llms.Models.algorithms.implementations
{
    public class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Flying with wings");
        }

    }
}
