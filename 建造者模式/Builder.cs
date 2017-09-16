using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace 建造者模式
{
    abstract class Builder
    {
        protected Graphics gp;
        protected Pen pen;
        public Builder(Graphics gp,Pen pen)
        {
            this.gp = gp;
            this.pen = pen;
        }
        public abstract void BuilderHead();
        public abstract void BuilderHands();
        public abstract void BuilderBody();

       
    }
}
