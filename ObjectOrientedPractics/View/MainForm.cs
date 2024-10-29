using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customerTab1.Customer = _store.Customers;
            itemsTab1.Items = _store.Items;
        }
        private Store _store = new Store();

        private void customerTab_Load(object sender, EventArgs e)
        {

        }
    }
}
