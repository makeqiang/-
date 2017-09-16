using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    class BuilderFat : Builder
    {
        public BuilderFat(Graphics gp, Pen pen) : base(gp, pen)//继承父类的构造函数
        {
            
        }
        public override void BuilderHead()
        {
            gp.DrawEllipse(pen,50,48,100,98);
        }
        public override void BuilderHands()
        {
            gp.DrawLine(pen,85,146,30,250);//left
            gp.DrawLine(pen, 120, 146, 180, 250);//right
        }
        public override void BuilderBody()
        {
            gp.DrawRectangle(pen,80,146,45,150);
        }
    }
}
