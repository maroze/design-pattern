using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public abstract class Duck
    {
        protected QuackBehavior quackBehavior;
        protected FlyBehavior flyBehavior;
        public string Swim()
        {
            return "Буль буль буль";
        }
        public abstract string Display();
        public string PerformQuack()
        {
            return quackBehavior.Quack();
        }
        public string PerformFly()
        {
            return flyBehavior.Fly();
        }
        public void SetFlyBehavior(FlyBehavior flyBehavior)
        {
            this.flyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(QuackBehavior quackBehavior)
        {
            this.quackBehavior = quackBehavior;
        }
    }
}
