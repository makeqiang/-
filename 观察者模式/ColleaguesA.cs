using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    /// <summary>
    /// 看直播的同事A
    /// </summary>
    class ColleaguesA 
    {
        public string name;
        private Notice notice;
        public ColleaguesA(string name, Notice notice) 
        {
            this.name = name;
            this.notice = notice;
        }

        public  void UpdateA()
        {
            Console.Write("{0},{1}关闭直播,继续工作",notice.BossState,name);
        }
    }
    class ColleaguesB
    {
        public string name;
        private Notice notice;
        public ColleaguesB(string name, Notice notice) 
        {
            this.name = name;
            this.notice = notice;
        }

        public  void UpdateB()
        {
            Console.Write("{0},{1}关闭股票,继续工作", notice.BossState, name);
        }
    }
}
