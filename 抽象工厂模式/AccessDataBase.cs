﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式
{
    class AccessDataBase:IDataBase
    {
        public IUser CreateDataBase()
        {
            return new AccessUser();
        }
    }
}
