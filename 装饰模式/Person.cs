using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
     class Person
    {
      public Person()
        {

        }
        private string Name;
        public Person(string name)
        {
            this.Name = name;
        }
        public virtual void Show()
        {
            Console.WriteLine("装扮的是{0}", Name);
        }
    }
}
