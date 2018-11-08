using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomCafe
{
    class Order
    {
        private int orderNo;
        private List<OrderItem> itemList = new List<OrderItem>();
        public int OrderNo
        {
            get { return orderNo; }
            set { orderNo = value; }
        }
        public List<OrderItem> ItemList
        {
            get { return itemList; }
            set { itemList = value; }
        }
        public Order(){}
        public void Add(OrderItem oi)
        {
        }
        public void Remove(int position)
        {
        }
        public double GetTotalAmt()
        {
            return 1.0;
        }
        public override string ToString()
        {
            return "Hi";
        }
    }
}
