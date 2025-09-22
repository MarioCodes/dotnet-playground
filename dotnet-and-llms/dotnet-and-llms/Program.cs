using llms.Models;
using llms.Models.algorithms.implementations;

namespace llms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Duck duck = new MallardDuck(new Quack(), new FlyNoWay());
            duck.PerformQuack();
            duck.PerformFly();
            duck.Display();
        }

    }
}
