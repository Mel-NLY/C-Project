using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomCafe
{
    class Beverage : Product
    {
        private double tradeIn;
        public double TradeIn
        {
            get { return tradeIn; }
            set { tradeIn = value; }
        }
        public Beverage() { }
        public Beverage(string Name, double Price):base(Name, Price)
        {
            tradeIn = TradeIn;
        }
        public override double GetPrice()
        {
            return 1.0;
        }
        public override string ToString()
        {
            return Name + "\n$" + Price.ToString("0.00");
        }
    }
}
