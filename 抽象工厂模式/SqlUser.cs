using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式
{
    class SqlUser:IUser
    {
        public void Insert(User user)
        {
            Console.Write("给Sql添加一条数据");
        }
        public IUser GetUser(int id)
        {
            Console.Write("从Sql获取一条数据");
            return new SqlUser();
        }
    }
}
