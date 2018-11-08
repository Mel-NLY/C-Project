using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomCafe
{
    class OrderItem
    {
        private int quantity;
        private MenuItem item;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public MenuItem Item
        {
            get { return item; }
            set { item = value; }
        }
        public OrderItem() { }
        public OrderItem(MenuItem Item)
        {
            item = Item;
        }
        public void AddQty()
        {
        }
        public bool RemoveQty()
        {
            return true;
        }
        public double GetItemTotalAmt()
        {
            return 1.0;
        }
        public override string ToString()
        {
            return Item.ToString();
        }
    }
}
