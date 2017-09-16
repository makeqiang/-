using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Person mkq = new Person("mkq");
            Console.WriteLine("\r\n第一种装扮");
            Tshirts ts = new Tshirts();
            Bigtrouser bt = new Bigtrouser();
            ts.Decorate(mkq);
            bt.Decorate(ts);
            bt.Show();
            Console.Read();
        }
    }
}
