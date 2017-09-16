using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    /// <summary>
    /// 被追求者类
    /// </summary>
    class Beauty
    {
        private string name;//私有化一个变量
        public string Name//给变量提供一个公共的方法
        {
            get { return name; }
            set { name = value; }
        }
    }
}
