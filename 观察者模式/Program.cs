using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss boss = new Boss();
            ColleaguesA A = new ColleaguesA("mkq", boss);
            ColleaguesB B = new ColleaguesB("wxl", boss);
            boss.update += new EventHandler(A.UpdateA);
            boss.update += new EventHandler(B.UpdateB);
            boss.BossState = " 大傻子回来了";
            boss.Noti();
            Console.ReadLine();
        }
    }
}
