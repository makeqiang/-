using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 外观模式
{
     class Person
    {
        StockA stockA;
        StockB stockB;
        public Person()
        {
            stockA = new StockA();
            stockB = new StockB();
        }
        public void BuyMethod()
        {
            stockA.Buy();
            stockB.Buy();
        }//调用方法组
        public void SellMethod()
        {
            stockA.Sell();
            stockB.Sell();
        }
    }
}
