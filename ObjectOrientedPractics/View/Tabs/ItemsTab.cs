using ObjectOrientedPractics.Services;
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
    public partial class ItemsTab : UserControl
    {
        public ItemsTab()
        {
            InitializeComponent();

        }
        List<ItemsTab> _items = new();
        private void AddSongsButton_Click(object sender, EventArgs e)
        {
            int cost = Convert.ToInt32(costSelectedItemTextBox.Text);
            string name = nameSelectedItemRichTextBox.Text;
            string discription = descriptionSelectedItemRichTextBox.Text;

            Item newItem = new Item(name, discription, cost);   
        }

    }
    
}
