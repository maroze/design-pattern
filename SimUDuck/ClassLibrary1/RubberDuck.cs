﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public class RubberDuck: Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Squeak();
        }
        public override string Display()
        {
            return "Резиновая утка " + flyBehavior.Fly() + quackBehavior.Quack() + GetType();
        }
        //public RubberDuck() : base(new FlyNoWay(), new Squeak())
        //{
        //}
    }
}
