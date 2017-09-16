using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 原型模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Cv  cv= new Cv("mkq");
            cv.SetSexAge("男", "20");
            cv.SetWorkExper("2017");
            Cv cv1 =(Cv)cv.Clone();
            cv1.SetWorkExper("2016");
            cv.Display();
            cv1.Display();
            Console.Read();
        }
    }
}
