using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            IDataBase dataBase = new AccessDataBase();
            IUser iuser= dataBase.CreateDataBase();
            iuser.Insert(user);
            iuser.GetUser(1);
            Console.Read();
        }
    }
}
