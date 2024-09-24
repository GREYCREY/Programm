namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            CustomerTabPage = new TabPage();
            itemTabPage = new TabPage();
            tabControl1 = new TabControl();
            bindingSource1 = new BindingSource(components);
            itemsTab1 = new View.Tabs.ItemsTab();
            itemTabPage.SuspendLayout();
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // CustomerTabPage
            // 
            CustomerTabPage.Location = new Point(4, 24);
            CustomerTabPage.Name = "CustomerTabPage";
            CustomerTabPage.Padding = new Padding(3);
            CustomerTabPage.Size = new Size(831, 560);
            CustomerTabPage.TabIndex = 1;
            CustomerTabPage.Text = "Customer";
            CustomerTabPage.UseVisualStyleBackColor = true;
            // 
            // itemTabPage
            // 
            itemTabPage.Controls.Add(itemsTab1);
            itemTabPage.Location = new Point(4, 24);
            itemTabPage.Name = "itemTabPage";
            itemTabPage.Padding = new Padding(3);
            itemTabPage.Size = new Size(831, 560);
            itemTabPage.TabIndex = 0;
            itemTabPage.Text = "Item";
            itemTabPage.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(itemTabPage);
            tabControl1.Controls.Add(CustomerTabPage);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(839, 588);
            tabControl1.TabIndex = 0;
            // 
            // itemsTab1
            // 
            itemsTab1.Location = new Point(3, 6);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(814, 556);
            itemsTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            ClientSize = new Size(863, 645);
            Controls.Add(tabControl1);
            Name = "MainForm";
            itemTabPage.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        private TabPage CustomerTabPage;
        private TabPage itemTabPage;
        private BindingSource bindingSource1;
        private System.ComponentModel.IContainer components;
        private View.Tabs.ItemsTab itemsTab1;
        private TabControl tabControl1;
    }
}
