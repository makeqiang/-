﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 外观模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.BuyMethod();
            person.SellMethod();
            Console.Read();
        }
    }
}
