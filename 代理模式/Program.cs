using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Beauty mm = new Beauty();
            mm.Name = "王雪丽";
            Agent at = new Agent(mm);
            at.SentDoll();
            at.SentFlowers();
            at.SentChocolate();
            Console.Read();
        }
    }
}
