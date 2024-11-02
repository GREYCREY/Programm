using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        public CartsTab()
        {
            InitializeComponent();
        }
        private List<Customer> _customers;
        private List<Cart> _cartsItems;
        private static Cart _currentCartItem = new Cart();
        private static Item _currentItem = new Item();

        public Customer CurrentCustomer
        {
            get; set;
        }
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
            }
        }
        public List<Cart> CartsItems
        {
            get { return _cartsItems; }
            set
            {
                _cartsItems = value;
            }
        }
        private List<Item> _items;
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;
            }
        }

        private void CartsTab_Load(object sender, EventArgs e)
        {

        }

        private void CartItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CartItemsListBox.SelectedIndex == -1)
            {
                CartListBox.Text = string.Empty;

            }
            else
            {
                _currentItem = _items[CartItemsListBox.SelectedIndex];
            }
        }
        public void RefreshData()
        {
            UpdateListBox();
            UpdateComboBox();
        }
        private void UpdateListBox()
        {
            CartItemsListBox.Items.Clear();
            for (int i = 0; i < Items.Count; i++)
            {
                CartItemsListBox.Items.Add(Items[i].Name);
            }

        }
        private void UpdateComboBox()
        {
            CartCustomerComboBox.Items.Clear();
            for (int i = 0; i < Customers.Count; i++)
            {
                CartCustomerComboBox.Items.Add(Customers[i].FullName);
            }
        }

        private void CartCustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CartCustomerComboBox.SelectedIndex == -1)
            {
                CartListBox.Text = string.Empty;
            }
            else
            {
                CurrentCustomer = _customers[CartCustomerComboBox.SelectedIndex];

                ///if(CurrentCustomer.Cart.Items.Count > 0) 
                //{
                ///  foreach (Item item in CurrentCustomer.Cart.Items)
                ///{
                /// CartListBox.Items.Add(CurrentCustomer.Cart.Items);
                ///}
                ///}


            }
        }
        
        private void CartAmount_Changed()
        {
            CartAmountDisplayLabel.Text = CurrentCustomer.Cart.Amount.ToString();

        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            CurrentCustomer.Cart.Items.Add(_currentItem);
            CartListBox.Items.Add(_currentItem.Name);
            CartAmountDisplayLabel.Text = CurrentCustomer.Cart.Amount.ToString();

        }

        private void CartListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CartRemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.SelectedIndex != -1)
            {
                CurrentCustomer.Cart.Items.RemoveAt(CartListBox.SelectedIndex);
                CartListBox.Items.RemoveAt(CartListBox.SelectedIndex);
                CartAmountDisplayLabel.Text = CurrentCustomer.Cart.Amount.ToString();

            }

        }

        private void CartCreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CartCustomerComboBox.SelectedIndex < 0) return;
            Order newOrder = new Order();
            newOrder.DeliveryAddress = CurrentCustomer.Address;
            newOrder.Cart.Items = CurrentCustomer.ItemsList;
            newOrder.Amount = CurrentCustomer.Cart.Amount;
            newOrder.Status = OrderStatus.New;
            CurrentCustomer.OrdersList.Add(newOrder);
            CartListBox.Items.Clear();
            CurrentCustomer.Cart.Items.Clear();
            CartAmountDisplayLabel.Text = CurrentCustomer.Cart.Amount.ToString();


        }

        private void CartClearButton_Click(object sender, EventArgs e)
        {
            
            
                CurrentCustomer.Cart.Items.Clear();
                CartListBox.Items.Clear();
                CartAmountDisplayLabel.Text = CurrentCustomer.Cart.Amount.ToString();


        }
    }
}
