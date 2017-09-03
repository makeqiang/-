using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式
{
    class OperationFactory : Operation
    {
        public static Operation CreateOperation(string oper)
        {
            Operation operation = null;
            switch (oper)
            {
                case "+":
                    operation = new OperationAdd();
                    break;
                case "-":
                    operation = new OperationSub();
                    break;
                case "*":
                    operation = new OperationMult();
                    break;
                case "/":
                    operation = new OperationDivision();
                    break;
                default:
                    break;
            }
            return operation;
        }
    }
}
