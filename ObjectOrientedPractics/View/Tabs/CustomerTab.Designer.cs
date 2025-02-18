namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomerTab
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
            Address address1 = new Address();
            Address address2 = new Address();
            SelectedItemGroupBox = new GroupBox();
            addressControl1 = new Controls.AddressControl();
            CustomerFullNameRichTextBox = new RichTextBox();
            CustomerFullNameLable = new Label();
            IDSelectedItemLabel = new Label();
            CustomerIDTextBox = new TextBox();
            addressControl = new Controls.AddressControl();
            CustomerListBox = new ListBox();
            DeleteButton = new Button();
            AddButton = new Button();
            ItemsGroupBox = new GroupBox();
            PriorityCheckBox = new CheckBox();
            SelectedItemGroupBox.SuspendLayout();
            ItemsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SelectedItemGroupBox
            // 
            SelectedItemGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedItemGroupBox.Controls.Add(PriorityCheckBox);
            SelectedItemGroupBox.Controls.Add(addressControl1);
            SelectedItemGroupBox.Controls.Add(CustomerFullNameRichTextBox);
            SelectedItemGroupBox.Controls.Add(CustomerFullNameLable);
            SelectedItemGroupBox.Controls.Add(IDSelectedItemLabel);
            SelectedItemGroupBox.Controls.Add(CustomerIDTextBox);
            SelectedItemGroupBox.Location = new Point(353, 12);
            SelectedItemGroupBox.Name = "SelectedItemGroupBox";
            SelectedItemGroupBox.Size = new Size(464, 544);
            SelectedItemGroupBox.TabIndex = 6;
            SelectedItemGroupBox.TabStop = false;
            SelectedItemGroupBox.Text = "Selected Customer";
            // 
            // addressControl1
            // 
            address1.Apartment = "112";
            address1.Building = "40";
            address1.City = "Томск";
            address1.Country = "Россия";
            address1.Index = 123456;
            address1.Street = "Пр. Ленина";
            addressControl1.Address = address1;
            addressControl1.Location = new Point(1, 140);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(457, 161);
            addressControl1.TabIndex = 6;
            // 
            // CustomerFullNameRichTextBox
            // 
            CustomerFullNameRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomerFullNameRichTextBox.Location = new Point(71, 70);
            CustomerFullNameRichTextBox.Name = "CustomerFullNameRichTextBox";
            CustomerFullNameRichTextBox.Size = new Size(387, 28);
            CustomerFullNameRichTextBox.TabIndex = 5;
            CustomerFullNameRichTextBox.Text = "";
            CustomerFullNameRichTextBox.TextChanged += CustomerFullNameRichTextBox_TextChanged;
            // 
            // CustomerFullNameLable
            // 
            CustomerFullNameLable.AutoSize = true;
            CustomerFullNameLable.Location = new Point(1, 83);
            CustomerFullNameLable.Name = "CustomerFullNameLable";
            CustomerFullNameLable.Size = new Size(64, 15);
            CustomerFullNameLable.TabIndex = 4;
            CustomerFullNameLable.Text = "Full Name:";
            // 
            // IDSelectedItemLabel
            // 
            IDSelectedItemLabel.AutoSize = true;
            IDSelectedItemLabel.Location = new Point(6, 35);
            IDSelectedItemLabel.Name = "IDSelectedItemLabel";
            IDSelectedItemLabel.Size = new Size(21, 15);
            IDSelectedItemLabel.TabIndex = 1;
            IDSelectedItemLabel.Text = "ID:";
            // 
            // CustomerIDTextBox
            // 
            CustomerIDTextBox.Location = new Point(71, 32);
            CustomerIDTextBox.Name = "CustomerIDTextBox";
            CustomerIDTextBox.ReadOnly = true;
            CustomerIDTextBox.Size = new Size(100, 23);
            CustomerIDTextBox.TabIndex = 0;
            // 
            // addressControl
            // 
            address2.Apartment = "112";
            address2.Building = "40";
            address2.City = "Томск";
            address2.Country = "Россия";
            address2.Index = 123456;
            address2.Street = "Пр. Ленина";
            addressControl.Address = address2;
            addressControl.Location = new Point(0, 0);
            addressControl.Name = "addressControl";
            addressControl.Size = new Size(406, 161);
            addressControl.TabIndex = 0;
            // 
            // CustomerListBox
            // 
            CustomerListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CustomerListBox.FormattingEnabled = true;
            CustomerListBox.ItemHeight = 15;
            CustomerListBox.Location = new Point(6, 22);
            CustomerListBox.Name = "CustomerListBox";
            CustomerListBox.Size = new Size(332, 454);
            CustomerListBox.TabIndex = 0;
            CustomerListBox.SelectedIndexChanged += CustomerListBox_SelectedIndexChanged;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DeleteButton.Location = new Point(208, 496);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(130, 50);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteItem_Click;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.Location = new Point(6, 496);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(130, 50);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddItem_Click;
            // 
            // ItemsGroupBox
            // 
            ItemsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsGroupBox.Controls.Add(CustomerListBox);
            ItemsGroupBox.Controls.Add(DeleteButton);
            ItemsGroupBox.Controls.Add(AddButton);
            ItemsGroupBox.Location = new Point(3, 3);
            ItemsGroupBox.Name = "ItemsGroupBox";
            ItemsGroupBox.Size = new Size(344, 552);
            ItemsGroupBox.TabIndex = 5;
            ItemsGroupBox.TabStop = false;
            ItemsGroupBox.Text = "Customer";
            // 
            // PriorityCheckBox
            // 
            PriorityCheckBox.AutoSize = true;
            PriorityCheckBox.Location = new Point(71, 115);
            PriorityCheckBox.Name = "PriorityCheckBox";
            PriorityCheckBox.Size = new Size(75, 19);
            PriorityCheckBox.TabIndex = 8;
            PriorityCheckBox.Text = "Is Priority";
            PriorityCheckBox.UseVisualStyleBackColor = true;
            PriorityCheckBox.CheckedChanged += PriorityCheckBox_CheckedChanged;
            // 
            // CustomerTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedItemGroupBox);
            Controls.Add(ItemsGroupBox);
            Name = "CustomerTab";
            Size = new Size(926, 558);
            SelectedItemGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.PerformLayout();
            ItemsGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox SelectedItemGroupBox;
        private RichTextBox CustomerFullNameRichTextBox;
        private Label CustomerFullNameLable;
        private Label IDSelectedItemLabel;
        private TextBox CustomerIDTextBox;
        private ListBox CustomerListBox;
        private Button DeleteButton;
        private Button AddButton;
        private GroupBox ItemsGroupBox;
        private Controls.AddressControl addressControl;
        private Controls.AddressControl addressControl1;
        private CheckBox PriorityCheckBox;
    }
}
