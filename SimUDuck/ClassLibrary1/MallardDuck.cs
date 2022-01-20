﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public class MallardDuck : Duck, Quackable, Flyable
    {
        public override string display()
        {
            return "Кряква " + this.GetType();
        }
        public string fly()
        {
            return "*Махаю крыльями* " + this.GetType();
        }
        public string quack()
        {
            return "Кря " + this.GetType();
        }
    }
}
