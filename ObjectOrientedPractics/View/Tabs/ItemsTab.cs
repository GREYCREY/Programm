
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
    public partial class ItemsTab : UserControl
    {
        /// <summary> 
        /// Хранит данные о созданных товарах 
        /// </summary> 
        
        public ItemsTab()
        {
            InitializeComponent();
        }
        private static List<Item> _items = new List<Item>();
        /// <summary> 
        /// Хранит данные о текущем товаре 
        /// </summary> 
        private static Item _currentItem = null;


        private void ItemListListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex < 0)
            {
                CostSelectedItemTextBox.Text = string.Empty;
                DescriptionSelectedItemRichTextBox.Text = string.Empty;
                NameSelectedItemRichTextBox.Text = string.Empty;
                IDSelectedItemTextBox.Text = string.Empty;
            }

            else
            {
                _currentItem = _items[ItemsListBox.SelectedIndex];
                CostSelectedItemTextBox.Text = _currentItem.Cost.ToString();
                DescriptionSelectedItemRichTextBox.Text = _currentItem.Info.ToString();
                NameSelectedItemRichTextBox.Text = _currentItem.Name.ToString();
                IDSelectedItemTextBox.Text = _currentItem.Id.ToString();
            }
        }

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

        /// <summary> 
        /// Записывает имена товаров в элемент ListBox. 
        /// </summary> 
        private void ChangeTextElemListBoxInstitution()
        {
            ItemsListBox.Items[ItemsListBox.SelectedIndex] = _items[ItemsListBox.SelectedIndex].Name;
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex < 0) { return; }
            else
            {
                _items.RemoveAt(ItemsListBox.SelectedIndex);
                ItemsListBox.Items.RemoveAt(ItemsListBox.SelectedIndex);
            }
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            Item newItem = new Item();
            _items.Add(newItem);
            ItemsListBox.Items.Add(newItem);
        }

        private void ItemsTab_Load(object sender, EventArgs e)
        {

        }
    }
}