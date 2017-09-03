using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式
{
    class OperationDivision:Operation
    {
        public override double GetResult()
        {
            if (NumberB !=0)
            {
                return NumberA / NumberB;
            }
            else
            {
                return 0;
            }
        }
    }
}
