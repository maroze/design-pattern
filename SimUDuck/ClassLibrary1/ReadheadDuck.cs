using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new DQuack();
        }
        //public RedHeadDuck() : base(new FlyWithWings(), new DQuack())
        //{
        //}
        public override string Display()
        {
            return "Красно-головая ";
        }
    }
}
