using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    /// <summary>
    /// 代理接口,追求者和代理都要遵循这个接口的约定
    /// </summary>
    interface Sent
    {
        void SentDoll();
        void SentFlowers();
        void SentChocolate();
    }
}
