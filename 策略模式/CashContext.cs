using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    class CashContext
    {
        private Cashier cashier;
        public CashContext(string type)//根据参数初始化相应的对象
        {
            switch (type)
            {
                case "正常收费":
                    cashier = new CashRebate("1");
                    break;
                case "六折":
                    cashier = new CashRebate("0.6");
                    break;
                case "满300减100":
                    cashier = new CashReturn("300", "100");
                    break;
                default:
                    cashier = new CashRebate("1");
                    break;
            }
        }
        public double GetResult(double money)//根据传入的策略对象,调用它的具体算法
        {
            return cashier.DiscountMoney(money);//实现Strategy类的方法
        }
    }
}
