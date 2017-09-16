using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模板方法模式
{
    class StudentA: Paper
    {
        public override string Langeuage()
        {
            return "杜甫";
        }

        public override string Math()
        {
            return "1";
        }
    }
    class StudentB : Paper
    {
        public override string Langeuage()
        {
            return "李白";
        }

        public override string Math()
        {
            return "2";
        }
    }
}
