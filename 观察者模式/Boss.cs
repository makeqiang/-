using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    /// <summary>
    /// 老板通知类
    /// </summary>
    /// 
    delegate void EventHandler();
    class Boss : Notice
    {
        public event EventHandler update;
        private string action;
        public void Noti()
        {
            update();
        }
        public string BossState
        {
            get { return action; }
            set { action = value; }
        }
    }
}
