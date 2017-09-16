using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂方法模式
{
    class OperationMult:Operation
    {
        public override double GetResult()
        {
            return NumberA * NumberB;
        }
    }
}
