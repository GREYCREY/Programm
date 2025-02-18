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
        private List<Customer> _customer;
        public List<Customer> Customer
        {
            get { return _customer; }
            set
            {
                _customer = value;
            }
        }

        /// <summary>
        /// Текущий выбранный клиент.
        /// </summary>
        public Customer _currentCustomer;

        /// <summary>
        /// Обработчик события изменения выбранного клиента в списке.
        /// Обновляет данные клиента при выборе нового элемента в списке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CustomerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerListBox.SelectedIndex == -1)
            {
                CustomerFullNameRichTextBox.Text = string.Empty;

                CustomerIDTextBox.Text = string.Empty;
            }
            else
            {
                _currentCustomer = Customer[CustomerListBox.SelectedIndex];
                _currentCustomer.Address = addressControl.Address;

                CustomerFullNameRichTextBox.Text = _currentCustomer.FullName.ToString();
                addressControl.Address = _currentCustomer.Address;
                CustomerIDTextBox.Text = _currentCustomer.Id.ToString();
                PriorityCheckBox.Checked = _currentCustomer.IsPriority;
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
            if (string.IsNullOrEmpty(CustomerFullNameRichTextBox.Text) || CustomerListBox.SelectedIndex == -1) return;
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
            Customer newCustomer = new Customer();
            newCustomer.Address = new Address();
            _customer.Add(newCustomer);
            CustomerListBox.Items.Add(newCustomer);
        }

        private void SelectedItemGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void PriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_currentCustomer != null)
            {
                if (PriorityCheckBox.Checked)
                {
                    _currentCustomer.IsPriority = true;
                }
                else
                {
                    _currentCustomer.IsPriority = false;
                }
            }
        }
    }
}
