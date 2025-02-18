namespace ObjectOrientedPractics
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>


        #endregion

        private void InitializeComponent()
        {
            CustomerTabPage = new TabPage();
            customerTab1 = new View.Tabs.CustomerTab();
            itemTabPage = new TabPage();
            itemsTab1 = new View.Tabs.ItemsTab();
            TabControl = new TabControl();
            CartTabPage = new TabPage();
            cartsTab1 = new View.Tabs.CartsTab();
            OrderTabPage = new TabPage();
            orderTab1 = new View.Tabs.OrderTab();
            tabPage1 = new TabPage();
            CustomerTabPage.SuspendLayout();
            itemTabPage.SuspendLayout();
            TabControl.SuspendLayout();
            CartTabPage.SuspendLayout();
            OrderTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // CustomerTabPage
            // 
            CustomerTabPage.Controls.Add(customerTab1);
            CustomerTabPage.Location = new Point(4, 24);
            CustomerTabPage.Name = "CustomerTabPage";
            CustomerTabPage.Padding = new Padding(3);
            CustomerTabPage.Size = new Size(848, 504);
            CustomerTabPage.TabIndex = 1;
            CustomerTabPage.Text = "Customer";
            CustomerTabPage.UseVisualStyleBackColor = true;
            // 
            // customerTab1
            // 
            customerTab1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customerTab1.Customer = null;
            customerTab1.Location = new Point(0, 6);
            customerTab1.Name = "customerTab1";
            customerTab1.Size = new Size(951, 502);
            customerTab1.TabIndex = 0;
            // 
            // itemTabPage
            // 
            itemTabPage.Controls.Add(itemsTab1);
            itemTabPage.Location = new Point(4, 24);
            itemTabPage.Name = "itemTabPage";
            itemTabPage.Padding = new Padding(3);
            itemTabPage.Size = new Size(848, 504);
            itemTabPage.TabIndex = 0;
            itemTabPage.Text = "Item";
            itemTabPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            itemsTab1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            itemsTab1.Items = null;
            itemsTab1.Location = new Point(3, 6);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(842, 495);
            itemsTab1.TabIndex = 0;
            // 
            // TabControl
            // 
            TabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControl.Controls.Add(itemTabPage);
            TabControl.Controls.Add(CustomerTabPage);
            TabControl.Controls.Add(CartTabPage);
            TabControl.Controls.Add(OrderTabPage);
            TabControl.Controls.Add(tabPage1);
            TabControl.Location = new Point(2, -1);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(856, 532);
            TabControl.TabIndex = 0;
            TabControl.SelectedIndexChanged += SelectedTabChanged;
            // 
            // CartTabPage
            // 
            CartTabPage.Controls.Add(cartsTab1);
            CartTabPage.Location = new Point(4, 24);
            CartTabPage.Name = "CartTabPage";
            CartTabPage.Padding = new Padding(3);
            CartTabPage.Size = new Size(848, 504);
            CartTabPage.TabIndex = 2;
            CartTabPage.Text = "Cart";
            CartTabPage.UseVisualStyleBackColor = true;
            // 
            // cartsTab1
            // 
            cartsTab1.CartsItems = null;
            cartsTab1.CurrentCustomer = null;
            cartsTab1.Customers = null;
            cartsTab1.Items = null;
            cartsTab1.Location = new Point(3, 3);
            cartsTab1.Name = "cartsTab1";
            cartsTab1.Size = new Size(789, 501);
            cartsTab1.TabIndex = 0;
            cartsTab1.Load += cartsTab1_Load;
            // 
            // OrderTabPage
            // 
            OrderTabPage.Controls.Add(orderTab1);
            OrderTabPage.Location = new Point(4, 24);
            OrderTabPage.Name = "OrderTabPage";
            OrderTabPage.Padding = new Padding(3);
            OrderTabPage.Size = new Size(848, 504);
            OrderTabPage.TabIndex = 3;
            OrderTabPage.Text = "Order";
            OrderTabPage.UseVisualStyleBackColor = true;
            // 
            // orderTab1
            // 
            orderTab1.Customers = null;
            orderTab1.Dock = DockStyle.Fill;
            orderTab1.Location = new Point(3, 3);
            orderTab1.Name = "orderTab1";
            orderTab1.Size = new Size(842, 498);
            orderTab1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(848, 504);
            tabPage1.TabIndex = 4;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            ClientSize = new Size(857, 531);
            Controls.Add(TabControl);
            Name = "MainForm";
            CustomerTabPage.ResumeLayout(false);
            itemTabPage.ResumeLayout(false);
            TabControl.ResumeLayout(false);
            CartTabPage.ResumeLayout(false);
            OrderTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TabPage CustomerTabPage;
        private TabPage itemTabPage;
        private System.ComponentModel.IContainer components;
        private View.Tabs.ItemsTab itemsTab1;
        private View.Tabs.CustomerTab customerTab1;
        private View.Tabs.OrderTab orderTab1;
        private TabControl TabControl;
        private TabPage CartTabPage;
        private View.Tabs.CartsTab cartsTab1;
        private TabPage OrderTabPage;
        private TabPage tabPage1;
    }
}
