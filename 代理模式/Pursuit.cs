using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    /// <summary>
    /// 追求者类,需要通过代理来追求美女,因为自己不认识
    /// </summary>
    class Pursuit:Sent
    {
        Beauty mm;
        public Pursuit(Beauty mm)
        {
            this.mm = mm;
        }
        public void SentChocolate()
        {
            Console.WriteLine(mm.Name + "送你杜蕾斯");
        }
        public void SentDoll()
        {
            Console.WriteLine(mm.Name + "送你七度空间");
        }

        public void SentFlowers()
        {
            Console.WriteLine(mm.Name + "送你黄瓜");
        }
    }
}
