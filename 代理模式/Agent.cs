using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    /// <summary>
    /// 代理类,把追求者要表达的东西送给被追求者
    /// </summary>
    class Agent:Sent
    {
        Pursuit ps;
        public Agent(Beauty mm)
        {
            ps = new Pursuit(mm);
        }

        public void SentChocolate()
        {
            ps.SentChocolate();
        }

        public void SentDoll()
        {
            ps.SentDoll();
        }

        public void SentFlowers()
        {
            ps.SentFlowers();
        }
    }
}
