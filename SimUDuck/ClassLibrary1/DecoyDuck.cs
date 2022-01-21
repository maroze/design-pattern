using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public class DecoyDuck: Duck
    {
        public DecoyDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new MuteQuack();
        }
        //public DecoyDuck() : base(new FlyNoWay(), new MuteQuack())
        //{
        //}
        public override string Display()
        {
            return "Деревянная утка-приманка ";
        }
    }
}
