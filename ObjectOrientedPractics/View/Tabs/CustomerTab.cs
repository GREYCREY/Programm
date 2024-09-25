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
    /// <summary>
    /// Вкладка управления клиентами в интерфейсе приложения.
    /// </summary>
    public partial class CustomerTab : UserControl
    {
        /// <summary>
        /// Конструктор по умолчанию, инициализирует компоненты вкладки.
        /// </summary>
        public CustomerTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Список клиентов.
        /// </summary>
        private static List<Customer> _customer = new List<Customer>();

        /// <summary>
        /// Текущий выбранный клиент.
        /// </summary>
        private static Customer _currentCustomer = null;

        /// <summary>
        /// Обработчик события изменения выбранного клиента в списке.
        /// Обновляет данные клиента при выборе нового элемента в списке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CustomerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerListBox.SelectedIndex < 0)
            {
                CustomerFullNameRichTextBox.Text = string.Empty;
                CustomerAddressRichTextBox.Text = string.Empty;
                CustomerIDTextBox.Text = string.Empty;
            }
            else
            {
                _currentCustomer = _customer[CustomerListBox.SelectedIndex];
                CustomerFullNameRichTextBox.Text = _currentCustomer.FullName.ToString();
                CustomerAddressRichTextBox.Text = _currentCustomer.Address.ToString();
                CustomerIDTextBox.Text = _currentCustomer.Id.ToString();
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле полного имени клиента.
        /// Пытается обновить полное имя клиента, меняя цвет фона поля в случае ошибки.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CustomerFullNameRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CustomerFullNameRichTextBox.Text)) return;
            try
            {
                CustomerFullNameRichTextBox.BackColor = Color.White;
                string customerFullName = CustomerFullNameRichTextBox.Text;
                _currentCustomer.FullName = customerFullName;
            }
            catch (Exception)
            {
                CustomerFullNameRichTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле адреса клиента.
        /// Пытается обновить адрес клиента, меняя цвет фона поля в случае ошибки.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CustomerAddressRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CustomerAddressRichTextBox.Text)) return;
            try
            {
                CustomerAddressRichTextBox.BackColor = Color.White;
                string customerAddress = CustomerAddressRichTextBox.Text;
                _currentCustomer.Address = customerAddress;
            }
            catch (Exception)
            {
                CustomerAddressRichTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обработчик события удаления выбранного клиента.
        /// Удаляет клиента из списка и обновляет интерфейс.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void DeleteItem_Click(object sender, EventArgs e)
        {
            if (CustomerListBox.SelectedIndex < 0) { return; }
            else
            {
                _customer.RemoveAt(CustomerListBox.SelectedIndex);
                CustomerListBox.Items.RemoveAt(CustomerListBox.SelectedIndex);
            }
        }

        /// <summary>
        /// Обработчик события добавления нового клиента.
        /// Добавляет нового клиента в список и обновляет интерфейс.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void AddItem_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer("London", "Alex");
            _customer.Add(newCustomer);
            CustomerListBox.Items.Add(newCustomer);
        }
    }
}
