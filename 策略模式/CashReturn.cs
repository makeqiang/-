using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    class CashReturn : Cashier
    {
        private double totalMoney = 0.0d;
        private double returnMoney = 0.0d;
        public CashReturn(string totalCash,string returnCash)
        {
             totalMoney = double.Parse(totalCash);
             returnMoney = double.Parse(returnCash);
        }
        public override double DiscountMoney(double money)
        {
            double result = money;
            if (money>=totalMoney)
            {
                money = money - Math.Floor(money / totalMoney)* returnMoney;
            }
            return money;
        }
    }
}
