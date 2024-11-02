using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrderTab : UserControl
    {
        public OrderTab()
        {
            InitializeComponent();
            OrderStatusComboBox.Items.AddRange(Enum.GetNames(typeof(OrderStatus)));
        }

        public List<Customer>? Customers { get; set; }
        private List<Order>? _orders = new List<Order>(5);
        private Order _currentOrder;

        public void RefreshData()
        {
            double amount = 0;
            if (Customers != null && DataGridView != null)
            {
                DataGridView.Rows.Clear();
                foreach (var customer in Customers)
                {
                    for (int i = 0; i < customer.OrdersList.Count; i++)
                    {
                        var order = customer.OrdersList[i];
                        _orders.Add(order);
                        amount += order.Amount;
                        if (customer.Address != null)
                        {
                            string address = $"{customer.Address.Index} {customer.Address.Country} {customer.Address.City} {customer.Address.Street} {customer.Address.Building} {customer.Address.Apartment}";
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(DataGridView, order.Id, order.Date.ToString(), customer.FullName, address, order.Amount, order.Status, order.Amount);
                            row.Tag = order; // Привязываем заказ к строке
                            DataGridView.Rows.Add(row);
                        }
                    }
                }
            }
            OrderAmountDisplayLabel.Text = amount.ToString();
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridView.SelectedRows.Count != 0)
            {
                _currentOrder = (Order)DataGridView.SelectedRows[0].Tag;

                SelectedOrderItemsListBox.Items.Clear();
                if (OrderAddressControl != null)
                {
                    OrderAddressControl.Address = _currentOrder.DeliveryAddress;
                }
                OrderIDTextBox.Text = _currentOrder.Id.ToString();
                OrderCreatedTextBox.Text = _currentOrder.Date.ToString();
                OrderStatusComboBox.SelectedIndex = (int)_currentOrder.Status;
                for (int i = 0; i < _currentOrder.Cart.Items.Count; i++)
                {
                    SelectedOrderItemsListBox.Items.Add(_currentOrder.Cart.Items[i].Name);
                }
            }
        }

        private void OrderStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentOrder != null && OrderStatusComboBox.SelectedItem != null)
            {
                // Меняем статус текущего заказа на выбранный в ComboBox
                _currentOrder.Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), (string)OrderStatusComboBox.SelectedItem);

                // Обновляем значение в DataGridView, если выбранная строка существует
                if (DataGridView.SelectedRows.Count > 0)
                {
                    DataGridView.SelectedRows[0].Cells[5].Value = _currentOrder.Status;
                }
            }
        }
    }
}
