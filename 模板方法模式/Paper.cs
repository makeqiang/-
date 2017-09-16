using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模板方法模式
{
    abstract class Paper
    {
        public abstract string Math();
        public abstract string Langeuage();
        public void PaperMethod()
        {
            Console.WriteLine("1.1+1={0}",Math());
            Console.WriteLine("1.诗仙={0}", Langeuage());
        }
    }
}
