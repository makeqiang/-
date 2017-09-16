using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    class BuilderThin : Builder
    {
        public BuilderThin(Graphics gp, Pen pen) : base(gp, pen)
        {
        }

        public override void BuilderBody()
        {
            gp.DrawEllipse(pen, 250, 48, 100, 98);
        }

        public override void BuilderHands()
        {
            gp.DrawLine(pen, 285, 146, 230, 250);//left
            gp.DrawLine(pen, 320, 146, 380, 250);//right
        }

        public override void BuilderHead()
        {
            gp.DrawRectangle(pen, 280, 146, 30, 150);
        }
    }
}
