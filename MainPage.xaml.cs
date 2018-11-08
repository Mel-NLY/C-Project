using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TomCafe
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<ValueMeal> valueMealList = new List<ValueMeal>();
        List<Side> sideList = new List<Side>();
        List<Beverage> beverageList = new List<Beverage>();
        List<MenuItem> menuItemList = new List<MenuItem>();
        List<OrderItem> orderItemList = new List<OrderItem>();
        List<string> cartDetailsList = new List<string>();
        private int listused = 1;
        private int qty = 0;
        public MainPage()
        {
            this.InitializeComponent();
            InitInfo();
            DisplayMenuItemList();
        }
        
        void InitInfo()
        {
            MenuItem mi1 = new MenuItem("Breakfast set \n(Hotcake with sausage, Hash brown)", 7.90);
            MenuItem mi2 = new MenuItem("Hamburger combo \n(Hamburger, fries, cola)", 10.20);
            MenuItem mi3 = new MenuItem("Dinner set \n(Ribeye steak, fries, caesar \nsalad, coffee)", 18.50);
            menuItemList.Add(mi1);
            menuItemList.Add(mi2);
            menuItemList.Add(mi3);
            ValueMeal vm1 = new ValueMeal("Hotcake with sausage", 6.90);
            ValueMeal vm2 = new ValueMeal("Hamburger", 7.50);
            ValueMeal vm3 = new ValueMeal("Ribeye Steak", 10.20);
            valueMealList.Add(vm1);
            valueMealList.Add(vm2);
            valueMealList.Add(vm3);
            Side s1 = new Side("Hash brown", 2.10);
            Side s2 = new Side("Truffle fries", 3.70);
            Side s3 = new Side("Calamari", 3.40);
            Side s4 = new Side("Caesar salad", 4.30);
            sideList.Add(s1);
            sideList.Add(s2);
            sideList.Add(s3);
            sideList.Add(s4);
            Beverage b1 = new Beverage("Cola", 2.85);
            Beverage b2 = new Beverage("Green Tea", 3.70);
            Beverage b3 = new Beverage("Coffee", 2.70);
            Beverage b4 = new Beverage("Tea", 2.70);
            Beverage b5 = new Beverage("Tom's Root Beer", 9.70);
            Beverage b6 = new Beverage("MockTail", 15.90);
            beverageList.Add(b1);
            beverageList.Add(b2);
            beverageList.Add(b3);
            beverageList.Add(b4);
            beverageList.Add(b5);
            beverageList.Add(b6);
        }
        public void DisplayMenuItemList()
        {
            List<string> itemDetailsList = new List<string>();
            foreach (MenuItem mi in menuItemList)
            {
                itemDetailsList.Add(mi.ToString());
            }
            itemsListView.ItemsSource = null;
            itemsListView.ItemsSource = itemDetailsList;
        }
        public void DisplayValueMealList()
        {
            List<string> itemDetailsList = new List<string>();
            foreach (ValueMeal vm in valueMealList)
            {
                itemDetailsList.Add(vm.ToString());
            }
            itemsListView.ItemsSource = null;
            itemsListView.ItemsSource = itemDetailsList;
        }
        public void DisplaySideList()
        {
            List<string> itemDetailsList = new List<string>();
            foreach (Side s in sideList)
            {
                itemDetailsList.Add(s.ToString());
            }
            itemsListView.ItemsSource = null;
            itemsListView.ItemsSource = itemDetailsList;
        }
        public void DisplayBeverageList()
        {
            List<string> itemDetailsList = new List<string>();
            foreach (Beverage b in beverageList)
            {
                itemDetailsList.Add(b.ToString());
            }
            itemsListView.ItemsSource = null;
            itemsListView.ItemsSource = itemDetailsList;
        }

        private void bundlesButton_Click(object sender, RoutedEventArgs e)
        {
            DisplayMenuItemList();
            listused = 1;
        }
        private void mainsButton_Click(object sender, RoutedEventArgs e)
        {
            DisplayValueMealList();
            listused = 2;
        }

        private void sidesButton_Click(object sender, RoutedEventArgs e)
        {
            DisplaySideList();
            listused = 3;
        }

        private void beveragesButton_Click(object sender, RoutedEventArgs e)
        {
            DisplayBeverageList();
            listused = 4;
        }
        /*public void DisplayOrderItemList()
        {
            List<string> itemDetailsList = new List<string>();
            foreach (OrderItem oi in orderItemList)
            {
                itemDetailsList.Add(oi.ToString());
            }
            cartsListView.ItemsSource = itemDetailsList;
        }*/
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            int i = itemsListView.SelectedIndex;
            if (i >= 0)
            {
                if (listused == 1)
                {
                    MenuItem mi = menuItemList[i];
                    string output = mi.ToString();
                    cartDetailsList.Add(output);
                    cartsListView.ItemsSource = null;
                    cartsListView.ItemsSource = cartDetailsList;
                }
                else if (listused == 2)
                {
                    ValueMeal vm = valueMealList[i];
                    string output = vm.ToString();
                    cartDetailsList.Add(output);
                    cartsListView.ItemsSource = null;
                    cartsListView.ItemsSource = cartDetailsList;
                }
                else if (listused == 3)
                {
                    Side s = sideList[i];
                    string output = s.ToString();
                    cartDetailsList.Add(output);
                    cartsListView.ItemsSource = null;
                    cartsListView.ItemsSource = cartDetailsList;
                }
                else if (listused == 4)
                {
                    Beverage b = beverageList[i];
                    string output = b.ToString();
                    cartDetailsList.Add(output);
                    cartsListView.ItemsSource = null;
                    cartsListView.ItemsSource = cartDetailsList;
                }
            }
        }
    }
}
