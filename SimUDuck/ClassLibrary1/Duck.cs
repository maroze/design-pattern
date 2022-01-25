using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public abstract class Duck
    {
        public QuackBehavior quackBehavior { get; set; }
        public FlyBehavior flyBehavior { get; set; }
        //protected Duck(FlyBehavior flyBehavior, QuackBehavior quackBehavior)
        //{
        //    this.flyBehavior = flyBehavior;
        //    this.quackBehavior = quackBehavior;
        //}
        public string Swim()
        {
            return "Буль буль буль";
        }
        public abstract string Display();
        public string performQuack()
        {
            return quackBehavior.Quack();
        }
        public string performFly()
        {
            return flyBehavior.Fly();
        }
        //public void PerformFly()
        //{
        //    flyBehavior.Fly();
        //}

        //public void PerformQuack()
        //{
        //    quackBehavior.Quack();
        //}
    }
}
