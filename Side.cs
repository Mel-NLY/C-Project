using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomCafe
{
    class Side : Product
    {
        public Side() { }
        public Side(string Name, double Price) : base(Name, Price)
        {
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
