namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            CartItemsLabel = new Label();
            CartItemsListBox = new ListBox();
            CartCustomerLabel = new Label();
            CartCustomerComboBox = new ComboBox();
            CartLabel = new Label();
            CartAmoubtLabel = new Label();
            CartAmountDisplayLabel = new Label();
            CartClearButton = new Button();
            CartRemoveItemButton = new Button();
            CartCreateOrderButton = new Button();
            AddToCartButton = new Button();
            CartListBox = new ListBox();
            SuspendLayout();
            // 
            // CartItemsLabel
            // 
            CartItemsLabel.AutoSize = true;
            CartItemsLabel.Location = new Point(3, 0);
            CartItemsLabel.Name = "CartItemsLabel";
            CartItemsLabel.Size = new Size(36, 15);
            CartItemsLabel.TabIndex = 0;
            CartItemsLabel.Text = "Items";
            // 
            // CartItemsListBox
            // 
            CartItemsListBox.FormattingEnabled = true;
            CartItemsListBox.ItemHeight = 15;
            CartItemsListBox.Location = new Point(3, 18);
            CartItemsListBox.Name = "CartItemsListBox";
            CartItemsListBox.Size = new Size(224, 439);
            CartItemsListBox.TabIndex = 1;
            CartItemsListBox.SelectedIndexChanged += CartItemsListBox_SelectedIndexChanged;
            // 
            // CartCustomerLabel
            // 
            CartCustomerLabel.AutoSize = true;
            CartCustomerLabel.Location = new Point(248, 18);
            CartCustomerLabel.Name = "CartCustomerLabel";
            CartCustomerLabel.Size = new Size(62, 15);
            CartCustomerLabel.TabIndex = 2;
            CartCustomerLabel.Text = "Customer:";
            // 
            // CartCustomerComboBox
            // 
            CartCustomerComboBox.FormattingEnabled = true;
            CartCustomerComboBox.Location = new Point(316, 18);
            CartCustomerComboBox.Name = "CartCustomerComboBox";
            CartCustomerComboBox.Size = new Size(469, 23);
            CartCustomerComboBox.TabIndex = 3;
            CartCustomerComboBox.SelectedIndexChanged += CartCustomerComboBox_SelectedIndexChanged;
            // 
            // CartLabel
            // 
            CartLabel.AutoSize = true;
            CartLabel.Location = new Point(248, 71);
            CartLabel.Name = "CartLabel";
            CartLabel.Size = new Size(32, 15);
            CartLabel.TabIndex = 4;
            CartLabel.Text = "Cart:";
            // 
            // CartAmoubtLabel
            // 
            CartAmoubtLabel.AutoSize = true;
            CartAmoubtLabel.Location = new Point(731, 198);
            CartAmoubtLabel.Name = "CartAmoubtLabel";
            CartAmoubtLabel.Size = new Size(54, 15);
            CartAmoubtLabel.TabIndex = 7;
            CartAmoubtLabel.Text = "Amount:";
            // 
            // CartAmountDisplayLabel
            // 
            CartAmountDisplayLabel.AutoSize = true;
            CartAmountDisplayLabel.Location = new Point(731, 213);
            CartAmountDisplayLabel.Name = "CartAmountDisplayLabel";
            CartAmountDisplayLabel.Size = new Size(28, 15);
            CartAmountDisplayLabel.TabIndex = 8;
            CartAmountDisplayLabel.Text = "0.00";
            // 
            // CartClearButton
            // 
            CartClearButton.Location = new Point(710, 251);
            CartClearButton.Name = "CartClearButton";
            CartClearButton.Size = new Size(75, 34);
            CartClearButton.TabIndex = 9;
            CartClearButton.Text = "Clear Cart";
            CartClearButton.UseVisualStyleBackColor = true;
            CartClearButton.Click += CartClearButton_Click;
            // 
            // CartRemoveItemButton
            // 
            CartRemoveItemButton.Location = new Point(615, 251);
            CartRemoveItemButton.Name = "CartRemoveItemButton";
            CartRemoveItemButton.Size = new Size(89, 34);
            CartRemoveItemButton.TabIndex = 10;
            CartRemoveItemButton.Text = "Remove Item";
            CartRemoveItemButton.UseVisualStyleBackColor = true;
            CartRemoveItemButton.Click += CartRemoveItemButton_Click;
            // 
            // CartCreateOrderButton
            // 
            CartCreateOrderButton.Location = new Point(248, 251);
            CartCreateOrderButton.Name = "CartCreateOrderButton";
            CartCreateOrderButton.Size = new Size(89, 34);
            CartCreateOrderButton.TabIndex = 11;
            CartCreateOrderButton.Text = "Create Order";
            CartCreateOrderButton.UseVisualStyleBackColor = true;
            CartCreateOrderButton.Click += CartCreateOrderButton_Click;
            // 
            // AddToCartButton
            // 
            AddToCartButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            AddToCartButton.Location = new Point(3, 463);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(89, 34);
            AddToCartButton.TabIndex = 12;
            AddToCartButton.Text = "Add To Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // CartListBox
            // 
            CartListBox.FormattingEnabled = true;
            CartListBox.ItemHeight = 15;
            CartListBox.Location = new Point(248, 89);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(537, 94);
            CartListBox.TabIndex = 13;
            CartListBox.SelectedIndexChanged += CartListBox_SelectedIndexChanged;
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CartListBox);
            Controls.Add(AddToCartButton);
            Controls.Add(CartCreateOrderButton);
            Controls.Add(CartRemoveItemButton);
            Controls.Add(CartClearButton);
            Controls.Add(CartAmountDisplayLabel);
            Controls.Add(CartAmoubtLabel);
            Controls.Add(CartLabel);
            Controls.Add(CartCustomerComboBox);
            Controls.Add(CartCustomerLabel);
            Controls.Add(CartItemsListBox);
            Controls.Add(CartItemsLabel);
            Name = "CartsTab";
            Size = new Size(789, 500);
            Load += CartsTab_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CartItemsLabel;
        private ListBox CartItemsListBox;
        private Label CartCustomerLabel;
        private ComboBox CartCustomerComboBox;
        private Label CartLabel;
        private Label CartAmoubtLabel;
        private Label CartAmountDisplayLabel;
        private Button CartClearButton;
        private Button CartRemoveItemButton;
        private Button CartCreateOrderButton;
        private Button AddToCartButton;
        private ListBox CartListBox;
    }
}
