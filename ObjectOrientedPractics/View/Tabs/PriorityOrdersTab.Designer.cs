namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            SelectedOrderLabel = new Label();
            fd = new Label();
            SlectedOrderIDLabel = new Label();
            CreatedLabel = new Label();
            StatusLabel = new Label();
            addressControl1 = new Controls.AddressControl();
            OrderItemsLabel = new Label();
            SelectedOrderAmountLabel = new Label();
            AmountDisplayLabel = new Label();
            OrderItemsRichTextBox = new RichTextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            AddItemButton = new Button();
            RemoveItemButton = new Button();
            ClearOrderButton = new Button();
            fsdfdsfdsf = new Label();
            DeliveryTimeComboBox = new ComboBox();
            SuspendLayout();
            // 
            // SelectedOrderLabel
            // 
            SelectedOrderLabel.AutoSize = true;
            SelectedOrderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedOrderLabel.Location = new Point(3, 0);
            SelectedOrderLabel.Name = "SelectedOrderLabel";
            SelectedOrderLabel.Size = new Size(92, 15);
            SelectedOrderLabel.TabIndex = 0;
            SelectedOrderLabel.Text = "Selected Order";
            // 
            // fd
            // 
            fd.AutoSize = true;
            fd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            fd.Location = new Point(201, 0);
            fd.Name = "fd";
            fd.Size = new Size(94, 15);
            fd.TabIndex = 1;
            fd.Text = "Priority Options";
            // 
            // SlectedOrderIDLabel
            // 
            SlectedOrderIDLabel.AutoSize = true;
            SlectedOrderIDLabel.Location = new Point(3, 27);
            SlectedOrderIDLabel.Name = "SlectedOrderIDLabel";
            SlectedOrderIDLabel.Size = new Size(21, 15);
            SlectedOrderIDLabel.TabIndex = 2;
            SlectedOrderIDLabel.Text = "ID:";
            // 
            // CreatedLabel
            // 
            CreatedLabel.AutoSize = true;
            CreatedLabel.Location = new Point(3, 55);
            CreatedLabel.Name = "CreatedLabel";
            CreatedLabel.Size = new Size(51, 15);
            CreatedLabel.TabIndex = 3;
            CreatedLabel.Text = "Created:";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(3, 83);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(42, 15);
            StatusLabel.TabIndex = 4;
            StatusLabel.Text = "Status:";
            // 
            // addressControl1
            // 
            addressControl1.Address = null;
            addressControl1.Location = new Point(3, 112);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(406, 161);
            addressControl1.TabIndex = 5;
            // 
            // OrderItemsLabel
            // 
            OrderItemsLabel.AutoSize = true;
            OrderItemsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OrderItemsLabel.Location = new Point(3, 276);
            OrderItemsLabel.Name = "OrderItemsLabel";
            OrderItemsLabel.Size = new Size(75, 15);
            OrderItemsLabel.TabIndex = 6;
            OrderItemsLabel.Text = "Order Items";
            // 
            // SelectedOrderAmountLabel
            // 
            SelectedOrderAmountLabel.AutoSize = true;
            SelectedOrderAmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedOrderAmountLabel.Location = new Point(321, 393);
            SelectedOrderAmountLabel.Name = "SelectedOrderAmountLabel";
            SelectedOrderAmountLabel.Size = new Size(55, 15);
            SelectedOrderAmountLabel.TabIndex = 7;
            SelectedOrderAmountLabel.Text = "Amount:";
            // 
            // AmountDisplayLabel
            // 
            AmountDisplayLabel.AutoSize = true;
            AmountDisplayLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountDisplayLabel.Location = new Point(284, 418);
            AmountDisplayLabel.Name = "AmountDisplayLabel";
            AmountDisplayLabel.Size = new Size(14, 15);
            AmountDisplayLabel.TabIndex = 8;
            AmountDisplayLabel.Text = "0";
            // 
            // OrderItemsRichTextBox
            // 
            OrderItemsRichTextBox.Location = new Point(3, 294);
            OrderItemsRichTextBox.Name = "OrderItemsRichTextBox";
            OrderItemsRichTextBox.Size = new Size(373, 96);
            OrderItemsRichTextBox.TabIndex = 9;
            OrderItemsRichTextBox.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(60, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(60, 48);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(60, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            // 
            // AddItemButton
            // 
            AddItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            AddItemButton.Location = new Point(3, 458);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(89, 34);
            AddItemButton.TabIndex = 13;
            AddItemButton.Text = "Add Item";
            AddItemButton.UseVisualStyleBackColor = true;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveItemButton.Location = new Point(98, 458);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(89, 34);
            RemoveItemButton.TabIndex = 14;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            // 
            // ClearOrderButton
            // 
            ClearOrderButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ClearOrderButton.Location = new Point(287, 458);
            ClearOrderButton.Name = "ClearOrderButton";
            ClearOrderButton.Size = new Size(89, 34);
            ClearOrderButton.TabIndex = 15;
            ClearOrderButton.Text = "Clear Order";
            ClearOrderButton.UseVisualStyleBackColor = true;
            // 
            // fsdfdsfdsf
            // 
            fsdfdsfdsf.AutoSize = true;
            fsdfdsfdsf.Location = new Point(201, 27);
            fsdfdsfdsf.Name = "fsdfdsfdsf";
            fsdfdsfdsf.Size = new Size(81, 15);
            fsdfdsfdsf.TabIndex = 16;
            fsdfdsfdsf.Text = "Delivery Time:";
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Location = new Point(288, 19);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(92, 23);
            DeliveryTimeComboBox.TabIndex = 17;
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DeliveryTimeComboBox);
            Controls.Add(fsdfdsfdsf);
            Controls.Add(ClearOrderButton);
            Controls.Add(RemoveItemButton);
            Controls.Add(AddItemButton);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(OrderItemsRichTextBox);
            Controls.Add(AmountDisplayLabel);
            Controls.Add(SelectedOrderAmountLabel);
            Controls.Add(OrderItemsLabel);
            Controls.Add(addressControl1);
            Controls.Add(StatusLabel);
            Controls.Add(CreatedLabel);
            Controls.Add(SlectedOrderIDLabel);
            Controls.Add(fd);
            Controls.Add(SelectedOrderLabel);
            Name = "PriorityOrdersTab";
            Size = new Size(390, 495);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SelectedOrderLabel;
        private Label fd;
        private Label SlectedOrderIDLabel;
        private Label CreatedLabel;
        private Label StatusLabel;
        private Controls.AddressControl addressControl1;
        private Label OrderItemsLabel;
        private Label SelectedOrderAmountLabel;
        private Label AmountDisplayLabel;
        private RichTextBox OrderItemsRichTextBox;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Button AddItemButton;
        private Button RemoveItemButton;
        private Button ClearOrderButton;
        private Label fsdfdsfdsf;
        private ComboBox DeliveryTimeComboBox;
    }
}
