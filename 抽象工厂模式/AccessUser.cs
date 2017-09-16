using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式
{
    class AccessUser : IUser
    {
        public IUser GetUser(int id)
        {
            Console.Write("从Access取得一条数据");
            return new AccessUser();
        }

        public void Insert(User user)
        {
            Console.Write("给Access添加一条数据");
        }
    }
}
