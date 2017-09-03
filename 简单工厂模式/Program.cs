using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation oper;
            oper = OperationFactory.CreateOperation(Console.ReadLine());
            oper.NumberA = Convert.ToDouble(Console.ReadLine());
            oper.NumberB = Convert.ToDouble(Console.ReadLine());
            Console.Write(oper.GetResult());
            Console.ReadLine();
        }
    }
}
