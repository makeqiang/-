using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    class CashRebate : Cashier
    {
        private double discount=0d;
        public CashRebate(string discount)
        {
            this.discount = double.Parse(discount);
        }
        public override double DiscountMoney(double money)
        {
            return discount * money;
        }
    }
}
