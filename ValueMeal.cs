using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomCafe
{
    class ValueMeal : Product
    {
        private DateTime startTime;
        private DateTime endTime;
        public DateTime StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }
        public DateTime EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }
        public ValueMeal() { }
        public ValueMeal(string Name, double Price) : base(Name, Price)
        {
            startTime = StartTime;
            endTime = EndTime;
        }
        public override double GetPrice()
        {
            return 1.0;
        }
        public bool IsAvailable()
        {
            return true;
        }
        public override string ToString()
        {
            return Name + "\n$" + Price.ToString("0.00");
        }
    }
}
