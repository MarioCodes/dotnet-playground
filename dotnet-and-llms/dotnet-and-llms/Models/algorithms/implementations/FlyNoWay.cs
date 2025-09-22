using llms.Models.algorithms.interfaces;
using System;

namespace llms.Models.algorithms.implementations
{
    public class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("this duck cannot fly");
        }

    }
}
