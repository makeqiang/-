using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 原型模式
{
    class Work:ICloneable
    {
        public string workExper { get; set; }
        public object Clone()
        {
            return (Work)MemberwiseClone();
        }
    }
}
