using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂方法模式
{
    class CreateAddFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationAdd();
        }
    }
    class CreateSubFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationSub();
        }
    }
    class CreateMultFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationMult();
        }
    }
    class CreateDivsionFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationDivision();
        }
    }
}
