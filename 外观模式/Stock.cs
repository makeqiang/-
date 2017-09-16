using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 外观模式
{
    class StockA 
    {
        public  void Buy()
        {
            Console.Write(  "买了彩票A");
        }

        public  void Sell()
        {
            Console.Write( "卖了彩票A"); 
        }
    }
    class StockB
    {
        public  void Buy()
        {
            Console.Write( "买了彩票B");
        }

        public  void Sell()
        {
            Console.Write( "卖了彩票B");
        }
    }
}
