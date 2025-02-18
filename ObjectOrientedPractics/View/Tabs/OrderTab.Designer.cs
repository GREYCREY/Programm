namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrderTab
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
            OrederIDLabel = new Label();
            OrderCreatedLabel = new Label();
            OrderStatusLabel = new Label();
            DataGridView = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            DateColumn = new DataGridViewTextBoxColumn();
            FullnameColumn = new DataGridViewTextBoxColumn();
            DeliveryAddressColumn = new DataGridViewTextBoxColumn();
            AmountColumn = new DataGridViewTextBoxColumn();
            StatusColumn = new DataGridViewTextBoxColumn();
            OrdersLabel = new Label();
            OrderIDTextBox = new TextBox();
            OrderCreatedTextBox = new TextBox();
            OrderStatusComboBox = new ComboBox();
            OrderAddressControl = new Controls.AddressControl();
            OrderItemsLabel = new Label();
            SelectedOrderItemsListBox = new ListBox();
            OredrAmountLabel = new Label();
            OrderAmountDisplayLabel = new Label();
            DeliveryTimeDateTimePicker = new DateTimePicker();
            DeliveryTimeLabel = new Label();
            PriorityOptionsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // SelectedOrderLabel
            // 
            SelectedOrderLabel.AutoSize = true;
            SelectedOrderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedOrderLabel.Location = new Point(318, 0);
            SelectedOrderLabel.Name = "SelectedOrderLabel";
            SelectedOrderLabel.Size = new Size(95, 15);
            SelectedOrderLabel.TabIndex = 0;
            SelectedOrderLabel.Text = "Selected Order:";
            // 
            // OrederIDLabel
            // 
            OrederIDLabel.AutoSize = true;
            OrederIDLabel.Location = new Point(318, 32);
            OrederIDLabel.Name = "OrederIDLabel";
            OrederIDLabel.Size = new Size(21, 15);
            OrederIDLabel.TabIndex = 1;
            OrederIDLabel.Text = "ID:";
            // 
            // OrderCreatedLabel
            // 
            OrderCreatedLabel.AutoSize = true;
            OrderCreatedLabel.Location = new Point(317, 61);
            OrderCreatedLabel.Name = "OrderCreatedLabel";
            OrderCreatedLabel.Size = new Size(51, 15);
            OrderCreatedLabel.TabIndex = 2;
            OrderCreatedLabel.Text = "Created:";
            // 
            // OrderStatusLabel
            // 
            OrderStatusLabel.AutoSize = true;
            OrderStatusLabel.Location = new Point(318, 91);
            OrderStatusLabel.Name = "OrderStatusLabel";
            OrderStatusLabel.Size = new Size(42, 15);
            OrderStatusLabel.TabIndex = 3;
            OrderStatusLabel.Text = "Status:";
            // 
            // DataGridView
            // 
            DataGridView.AllowUserToAddRows = false;
            DataGridView.AllowUserToDeleteRows = false;
            DataGridView.AllowUserToResizeColumns = false;
            DataGridView.AllowUserToResizeRows = false;
            DataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Columns.AddRange(new DataGridViewColumn[] { IdColumn, DateColumn, FullnameColumn, DeliveryAddressColumn, AmountColumn, StatusColumn });
            DataGridView.Location = new Point(0, 18);
            DataGridView.MultiSelect = false;
            DataGridView.Name = "DataGridView";
            DataGridView.ReadOnly = true;
            DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView.ShowCellToolTips = false;
            DataGridView.ShowEditingIcon = false;
            DataGridView.Size = new Size(303, 479);
            DataGridView.TabIndex = 4;
            DataGridView.SelectionChanged += DataGridView_SelectionChanged;
            // 
            // IdColumn
            // 
            IdColumn.HeaderText = "Id";
            IdColumn.Name = "IdColumn";
            IdColumn.ReadOnly = true;
            IdColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // DateColumn
            // 
            DateColumn.HeaderText = "Date";
            DateColumn.Name = "DateColumn";
            DateColumn.ReadOnly = true;
            DateColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // FullnameColumn
            // 
            FullnameColumn.HeaderText = "Full Name";
            FullnameColumn.Name = "FullnameColumn";
            FullnameColumn.ReadOnly = true;
            FullnameColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // DeliveryAddressColumn
            // 
            DeliveryAddressColumn.HeaderText = "Delivery Address";
            DeliveryAddressColumn.Name = "DeliveryAddressColumn";
            DeliveryAddressColumn.ReadOnly = true;
            DeliveryAddressColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // AmountColumn
            // 
            AmountColumn.HeaderText = "Amount";
            AmountColumn.Name = "AmountColumn";
            AmountColumn.ReadOnly = true;
            AmountColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // StatusColumn
            // 
            StatusColumn.HeaderText = "Status";
            StatusColumn.Name = "StatusColumn";
            StatusColumn.ReadOnly = true;
            StatusColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // OrdersLabel
            // 
            OrdersLabel.AutoSize = true;
            OrdersLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OrdersLabel.Location = new Point(3, 0);
            OrdersLabel.Name = "OrdersLabel";
            OrdersLabel.Size = new Size(45, 15);
            OrdersLabel.TabIndex = 5;
            OrdersLabel.Text = "Orders";
            // 
            // OrderIDTextBox
            // 
            OrderIDTextBox.Location = new Point(388, 24);
            OrderIDTextBox.Name = "OrderIDTextBox";
            OrderIDTextBox.ReadOnly = true;
            OrderIDTextBox.Size = new Size(121, 23);
            OrderIDTextBox.TabIndex = 6;
            // 
            // OrderCreatedTextBox
            // 
            OrderCreatedTextBox.Location = new Point(388, 53);
            OrderCreatedTextBox.Name = "OrderCreatedTextBox";
            OrderCreatedTextBox.ReadOnly = true;
            OrderCreatedTextBox.Size = new Size(121, 23);
            OrderCreatedTextBox.TabIndex = 7;
            // 
            // OrderStatusComboBox
            // 
            OrderStatusComboBox.FormattingEnabled = true;
            OrderStatusComboBox.Location = new Point(388, 83);
            OrderStatusComboBox.Name = "OrderStatusComboBox";
            OrderStatusComboBox.Size = new Size(121, 23);
            OrderStatusComboBox.TabIndex = 8;
            OrderStatusComboBox.SelectedIndexChanged += OrderStatusComboBox_SelectedIndexChanged;
            // 
            // OrderAddressControl
            // 
            OrderAddressControl.Address = null;
            OrderAddressControl.Enabled = false;
            OrderAddressControl.Location = new Point(309, 123);
            OrderAddressControl.Name = "OrderAddressControl";
            OrderAddressControl.Size = new Size(463, 150);
            OrderAddressControl.TabIndex = 9;
            // 
            // OrderItemsLabel
            // 
            OrderItemsLabel.AutoSize = true;
            OrderItemsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OrderItemsLabel.Location = new Point(318, 287);
            OrderItemsLabel.Name = "OrderItemsLabel";
            OrderItemsLabel.Size = new Size(42, 15);
            OrderItemsLabel.TabIndex = 10;
            OrderItemsLabel.Text = "Items:";
            // 
            // SelectedOrderItemsListBox
            // 
            SelectedOrderItemsListBox.FormattingEnabled = true;
            SelectedOrderItemsListBox.ItemHeight = 15;
            SelectedOrderItemsListBox.Location = new Point(317, 305);
            SelectedOrderItemsListBox.Name = "SelectedOrderItemsListBox";
            SelectedOrderItemsListBox.Size = new Size(455, 124);
            SelectedOrderItemsListBox.TabIndex = 11;
            // 
            // OredrAmountLabel
            // 
            OredrAmountLabel.AutoSize = true;
            OredrAmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OredrAmountLabel.Location = new Point(720, 432);
            OredrAmountLabel.Name = "OredrAmountLabel";
            OredrAmountLabel.Size = new Size(55, 15);
            OredrAmountLabel.TabIndex = 13;
            OredrAmountLabel.Text = "Amount:";
            // 
            // OrderAmountDisplayLabel
            // 
            OrderAmountDisplayLabel.AutoSize = true;
            OrderAmountDisplayLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OrderAmountDisplayLabel.Location = new Point(696, 447);
            OrderAmountDisplayLabel.Name = "OrderAmountDisplayLabel";
            OrderAmountDisplayLabel.Size = new Size(31, 15);
            OrderAmountDisplayLabel.TabIndex = 14;
            OrderAmountDisplayLabel.Text = "0.00";
            // 
            // DeliveryTimeDateTimePicker
            // 
            DeliveryTimeDateTimePicker.Location = new Point(638, 21);
            DeliveryTimeDateTimePicker.Name = "DeliveryTimeDateTimePicker";
            DeliveryTimeDateTimePicker.Size = new Size(89, 23);
            DeliveryTimeDateTimePicker.TabIndex = 15;
            DeliveryTimeDateTimePicker.ValueChanged += DeliveryTimeDateTimePicker_ValueChanged;
            // 
            // DeliveryTimeLabel
            // 
            DeliveryTimeLabel.AutoSize = true;
            DeliveryTimeLabel.Location = new Point(545, 27);
            DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            DeliveryTimeLabel.Size = new Size(81, 15);
            DeliveryTimeLabel.TabIndex = 18;
            DeliveryTimeLabel.Text = "Delivery Time:";
            // 
            // PriorityOptionsLabel
            // 
            PriorityOptionsLabel.AutoSize = true;
            PriorityOptionsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PriorityOptionsLabel.Location = new Point(545, 0);
            PriorityOptionsLabel.Name = "PriorityOptionsLabel";
            PriorityOptionsLabel.Size = new Size(94, 15);
            PriorityOptionsLabel.TabIndex = 17;
            PriorityOptionsLabel.Text = "Priority Options";
            // 
            // OrderTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DeliveryTimeLabel);
            Controls.Add(PriorityOptionsLabel);
            Controls.Add(DeliveryTimeDateTimePicker);
            Controls.Add(OrderAmountDisplayLabel);
            Controls.Add(OredrAmountLabel);
            Controls.Add(SelectedOrderItemsListBox);
            Controls.Add(OrderItemsLabel);
            Controls.Add(OrderAddressControl);
            Controls.Add(OrderStatusComboBox);
            Controls.Add(OrderCreatedTextBox);
            Controls.Add(OrderIDTextBox);
            Controls.Add(OrdersLabel);
            Controls.Add(DataGridView);
            Controls.Add(OrderStatusLabel);
            Controls.Add(OrderCreatedLabel);
            Controls.Add(OrederIDLabel);
            Controls.Add(SelectedOrderLabel);
            Name = "OrderTab";
            Size = new Size(775, 497);
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SelectedOrderLabel;
        private Label OrederIDLabel;
        private Label OrderCreatedLabel;
        private Label OrderStatusLabel;
        private DataGridView DataGridView;
        private Label OrdersLabel;
        private TextBox OrderIDTextBox;
        private TextBox OrderCreatedTextBox;
        private ComboBox OrderStatusComboBox;
        private Controls.AddressControl OrderAddressControl;
        private Label OrderItemsLabel;
        private ListBox SelectedOrderItemsListBox;
        private Label OredrAmountLabel;
        private Label OrderAmountDisplayLabel;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn DateColumn;
        private DataGridViewTextBoxColumn FullnameColumn;
        private DataGridViewTextBoxColumn DeliveryAddressColumn;
        private DataGridViewTextBoxColumn AmountColumn;
        private DataGridViewTextBoxColumn StatusColumn;
        private DateTimePicker DeliveryTimeDateTimePicker;
        private Label DeliveryTimeLabel;
        private Label PriorityOptionsLabel;
    }
}
