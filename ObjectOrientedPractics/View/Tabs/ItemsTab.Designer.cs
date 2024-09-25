namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            ItemsListBox = new ListBox();
            AddButton = new Button();
            DeleteButton = new Button();
            ItemsGroupBox = new GroupBox();
            SelectedItemGroupBox = new GroupBox();
            DescriptionSelectedItemRichTextBox = new RichTextBox();
            descriptionSelectedItemLable = new Label();
            NameSelectedItemRichTextBox = new RichTextBox();
            NameSelectedItemLable = new Label();
            CostSelectedItemTextBox = new TextBox();
            CostSelectedItemLabel = new Label();
            IDSelectedItemLabel = new Label();
            IDSelectedItemTextBox = new TextBox();
            ItemsGroupBox.SuspendLayout();
            SelectedItemGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsListBox
            // 
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(6, 22);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(332, 469);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.SelectedIndexChanged += ItemListListBox_SelectedIndexChanged;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(6, 497);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(130, 50);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddItem_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(208, 497);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(130, 50);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteItem_Click;
            // 
            // ItemsGroupBox
            // 
            ItemsGroupBox.Controls.Add(ItemsListBox);
            ItemsGroupBox.Controls.Add(DeleteButton);
            ItemsGroupBox.Controls.Add(AddButton);
            ItemsGroupBox.Location = new Point(0, 3);
            ItemsGroupBox.Name = "ItemsGroupBox";
            ItemsGroupBox.Size = new Size(344, 553);
            ItemsGroupBox.TabIndex = 3;
            ItemsGroupBox.TabStop = false;
            ItemsGroupBox.Text = "Items";
            // 
            // SelectedItemGroupBox
            // 
            SelectedItemGroupBox.Controls.Add(DescriptionSelectedItemRichTextBox);
            SelectedItemGroupBox.Controls.Add(descriptionSelectedItemLable);
            SelectedItemGroupBox.Controls.Add(NameSelectedItemRichTextBox);
            SelectedItemGroupBox.Controls.Add(NameSelectedItemLable);
            SelectedItemGroupBox.Controls.Add(CostSelectedItemTextBox);
            SelectedItemGroupBox.Controls.Add(CostSelectedItemLabel);
            SelectedItemGroupBox.Controls.Add(IDSelectedItemLabel);
            SelectedItemGroupBox.Controls.Add(IDSelectedItemTextBox);
            SelectedItemGroupBox.Location = new Point(350, 12);
            SelectedItemGroupBox.Name = "SelectedItemGroupBox";
            SelectedItemGroupBox.Size = new Size(464, 544);
            SelectedItemGroupBox.TabIndex = 4;
            SelectedItemGroupBox.TabStop = false;
            SelectedItemGroupBox.Text = "Selected Item";
            // 
            // DescriptionSelectedItemRichTextBox
            // 
            DescriptionSelectedItemRichTextBox.Location = new Point(6, 259);
            DescriptionSelectedItemRichTextBox.Name = "DescriptionSelectedItemRichTextBox";
            DescriptionSelectedItemRichTextBox.Size = new Size(455, 96);
            DescriptionSelectedItemRichTextBox.TabIndex = 7;
            DescriptionSelectedItemRichTextBox.Text = "";
            DescriptionSelectedItemRichTextBox.TextChanged += ItemDescriptoinRichTextBox_TextChanged;
            // 
            // descriptionSelectedItemLable
            // 
            descriptionSelectedItemLable.AutoSize = true;
            descriptionSelectedItemLable.Location = new Point(6, 241);
            descriptionSelectedItemLable.Name = "descriptionSelectedItemLable";
            descriptionSelectedItemLable.Size = new Size(70, 15);
            descriptionSelectedItemLable.TabIndex = 6;
            descriptionSelectedItemLable.Text = "Description:";
            // 
            // NameSelectedItemRichTextBox
            // 
            NameSelectedItemRichTextBox.Location = new Point(6, 133);
            NameSelectedItemRichTextBox.Name = "NameSelectedItemRichTextBox";
            NameSelectedItemRichTextBox.Size = new Size(455, 96);
            NameSelectedItemRichTextBox.TabIndex = 5;
            NameSelectedItemRichTextBox.Text = "";
            NameSelectedItemRichTextBox.TextChanged += ItemNameRichTextBox_TextChanged;
            // 
            // NameSelectedItemLable
            // 
            NameSelectedItemLable.AutoSize = true;
            NameSelectedItemLable.Location = new Point(6, 115);
            NameSelectedItemLable.Name = "NameSelectedItemLable";
            NameSelectedItemLable.Size = new Size(42, 15);
            NameSelectedItemLable.TabIndex = 4;
            NameSelectedItemLable.Text = "Name:";
            // 
            // CostSelectedItemTextBox
            // 
            CostSelectedItemTextBox.Location = new Point(49, 68);
            CostSelectedItemTextBox.Name = "CostSelectedItemTextBox";
            CostSelectedItemTextBox.Size = new Size(100, 23);
            CostSelectedItemTextBox.TabIndex = 3;
            CostSelectedItemTextBox.TextChanged += ItemCostTextBox_TextChanged;
            // 
            // CostSelectedItemLabel
            // 
            CostSelectedItemLabel.AutoSize = true;
            CostSelectedItemLabel.Location = new Point(6, 75);
            CostSelectedItemLabel.Name = "CostSelectedItemLabel";
            CostSelectedItemLabel.Size = new Size(34, 15);
            CostSelectedItemLabel.TabIndex = 2;
            CostSelectedItemLabel.Text = "Cost:";
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
            // IDSelectedItemTextBox
            // 
            IDSelectedItemTextBox.Location = new Point(49, 31);
            IDSelectedItemTextBox.Name = "IDSelectedItemTextBox";
            IDSelectedItemTextBox.ReadOnly = true;
            IDSelectedItemTextBox.Size = new Size(100, 23);
            IDSelectedItemTextBox.TabIndex = 0;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedItemGroupBox);
            Controls.Add(ItemsGroupBox);
            Name = "ItemsTab";
            Size = new Size(814, 556);
            Load += ItemsTab_Load;
            ItemsGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox ItemsListBox;
        private Button AddButton;
        private Button DeleteButton;
        private GroupBox ItemsGroupBox;
        private GroupBox SelectedItemGroupBox;
        private TextBox CostSelectedItemTextBox;
        private Label CostSelectedItemLabel;
        private Label IDSelectedItemLabel;
        private TextBox IDSelectedItemTextBox;
        private RichTextBox NameSelectedItemRichTextBox;
        private Label NameSelectedItemLable;
        private RichTextBox DescriptionSelectedItemRichTextBox;
        private Label descriptionSelectedItemLable;
    }
}
