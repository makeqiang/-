using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模板方法模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("学生A\r\n");
            Paper paperA = new StudentA();
            paperA.PaperMethod();
            Console.Write("学生B\r\n");
            Paper pagerB = new StudentB();
            pagerB.PaperMethod();
            Console.Read();
        }
    }
}
