using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 原型模式
{
     class Cv:ICloneable
    {
        public string name;
        public string sex;
        public string age;
        public Work work;
        public Cv(string name)
        {
            this.name = name;
            work = new Work();
        }
        private Cv(Work work)
        {
            this.work = (Work)work.Clone();
        }
        public void SetSexAge(string sex, string age)
        {
            this.sex = sex;
            this.age = age;
        }
        public void SetWorkExper(string work)
        {
            this.work.workExper = work;
        }
        public void Display()
        {
            Console.WriteLine("姓名:{0}\r\n性别:{1}年龄:{2}\r\n工作经历:{3}\r\n",name,sex,age,work.workExper);
        }
        public object Clone()
        {
            Cv cv = new Cv(work);
            cv.name = name;
            cv.sex = sex;
            cv.age = age;
            return cv;
        }
    }
}
