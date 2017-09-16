using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂方法模式
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new CreateAddFactory();
            Operation oper = factory.CreateOperation();
            oper.NumberA = 1;
            oper.NumberB = 2;
            Console.WriteLine(oper.GetResult());
            Console.Read();
        }
    }
}
