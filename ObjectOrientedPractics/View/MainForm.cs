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
            cartsTab1.Items = _store.Items;
            cartsTab1.Customers = _store.Customers;
        }
        private Store _store = new Store();

        private void SelectedTabChanged(object sender, EventArgs e)
        {
            cartsTab1.RefreshData();
        }
        private void cartsTab1_Load(object sender, EventArgs e)
        {

        }
    }
}
