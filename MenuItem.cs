using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomCafe
{
    class MenuItem
    {
        private string name;
        private double price;
        private List<Product> productList = new List<Product>();
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public List<Product> ProductList
        {
            get { return productList; }
            set { productList = value; }
        }
        public MenuItem() { }
        public MenuItem(string Name, double Price)
        {
            name = Name;
            price = Price;
        }
        public double GetTotalPrice()
        {
            return 1.0;
        }
        public override string ToString()
        {
            return Name + "\n$" + Price.ToString("0.00");
        }
    }
}
