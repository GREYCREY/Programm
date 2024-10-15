using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка для управления товарами в интерфейсе приложения.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Конструктор по умолчанию, инициализирует компоненты вкладки.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            CategoryItemComboBox_InitializeComponents();
        }

        /// <summary>
        /// Список созданных товаров.
        /// </summary>
        private static List<Item> _items = new List<Item>();

        /// <summary>
        /// Текущий выбранный товар.
        /// </summary>
        private static Item _currentItem = null;

        /// <summary>
        /// Обработчик события изменения выбранного товара в списке.
        /// Обновляет данные товара при выборе нового элемента в списке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ItemListListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex < 0)
            {
                CostSelectedItemTextBox.Text = string.Empty;
                DescriptionSelectedItemRichTextBox.Text = string.Empty;
                NameSelectedItemRichTextBox.Text = string.Empty;
                IDSelectedItemTextBox.Text = string.Empty;
                CategoryItemComboBox.Items.Clear();
            }
            else
            {
                _currentItem = _items[ItemsListBox.SelectedIndex];
                CostSelectedItemTextBox.Text = _currentItem.Cost.ToString();
                DescriptionSelectedItemRichTextBox.Text = _currentItem.Info.ToString();
                NameSelectedItemRichTextBox.Text = _currentItem.Name.ToString();
                IDSelectedItemTextBox.Text = _currentItem.Id.ToString();
                Item selectedItem = (Item)ItemsListBox.SelectedItem;
                CategoryItemComboBox.SelectedItem = selectedItem.Category;
            }
            
        }

        /// <summary>
        /// Обработчик события изменения стоимости товара.
        /// Пытается обновить стоимость товара, меняя цвет фона поля в случае ошибки.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ItemCostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CostSelectedItemTextBox.Text)) return;
            try
            {
                CostSelectedItemTextBox.BackColor = Color.White;
                double itemCost = double.Parse(CostSelectedItemTextBox.Text);
                _currentItem.Cost = itemCost;
            }
            catch (Exception)
            {
                CostSelectedItemTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обработчик события изменения имени товара.
        /// Пытается обновить имя товара, меняя цвет фона поля в случае ошибки.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ItemNameRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameSelectedItemRichTextBox.Text)) return;
            try
            {
                NameSelectedItemRichTextBox.BackColor = Color.White;
                string itemName = NameSelectedItemRichTextBox.Text;
                _currentItem.Name = itemName;
            }
            catch (Exception)
            {
                NameSelectedItemRichTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обработчик события изменения описания товара.
        /// Пытается обновить описание товара, меняя цвет фона поля в случае ошибки.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ItemDescriptoinRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DescriptionSelectedItemRichTextBox.Text)) return;
            try
            {
                DescriptionSelectedItemRichTextBox.BackColor = Color.White;
                string itemInfo = DescriptionSelectedItemRichTextBox.Text;
                _currentItem.Info = itemInfo;
            }
            catch (Exception)
            {
                DescriptionSelectedItemRichTextBox.BackColor = Color.LightPink;
            }
        }
        private void CategoryItemComboBox_InitializeComponents()
        {
            CategoryItemComboBox.Items.AddRange(Enum.GetValues(typeof(Category)).Cast<object>().ToArray());
            CategoryItemComboBox.SelectedIndex = 0;
            

        }
        private void CategoryItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ItemsListBox.SelectedItem != null && CategoryItemComboBox.SelectedItem != null)
            {
                Item selectedItem = (Item)ItemsListBox.SelectedItem;
                selectedItem.Category = (Category)CategoryItemComboBox.SelectedItem;
                ItemsListBox.Items[ItemsListBox.SelectedIndex] = selectedItem;
                

            }
        }

        /// <summary>
        /// Обновляет текстовое представление товаров в элементе ListBox.
        /// </summary>
        private void ChangeTextElemListBoxInstitution()
        {
            ItemsListBox.Items[ItemsListBox.SelectedIndex] = _items[ItemsListBox.SelectedIndex].Name;
        }

        /// <summary>
        /// Обработчик события удаления выбранного товара.
        /// Удаляет товар из списка и обновляет интерфейс.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void DeleteItem_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex < 0) { return; }
            else
            {
                _items.RemoveAt(ItemsListBox.SelectedIndex);
                ItemsListBox.Items.RemoveAt(ItemsListBox.SelectedIndex);
            }
        }

        /// <summary>
        /// Обработчик события добавления нового товара.
        /// Добавляет новый товар в список и обновляет интерфейс.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void AddItem_Click(object sender, EventArgs e)
        {
            Item newItem = new Item();
            _items.Add(newItem);
            ItemsListBox.Items.Add(newItem);
        }

        /// <summary>
        /// Обработчик события загрузки вкладки.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ItemsTab_Load(object sender, EventArgs e)
        {
            
        }
    }
}
