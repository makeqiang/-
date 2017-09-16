using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    class BuilderController
    {
        Builder builder;
        public BuilderController(Builder builder)
        {
            this.builder = builder;
        }
        public void AllMethod()
        {
            builder.BuilderHead();
            builder.BuilderHands();
            builder.BuilderBody();
        }
    }
}
