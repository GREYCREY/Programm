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
            button1 = new Button();
            button2 = new Button();
            ItemsGroupBox = new GroupBox();
            SelectedItemGroupBox = new GroupBox();
            descriptionSelectedItemRichTextBox = new RichTextBox();
            descriptionSelectedItemLable = new Label();
            nameSelectedItemRichTextBox = new RichTextBox();
            NameSelectedItemLable = new Label();
            costSelectedItemTextBox = new TextBox();
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
            // 
            // button1
            // 
            button1.Location = new Point(6, 497);
            button1.Name = "button1";
            button1.Size = new Size(130, 50);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(208, 497);
            button2.Name = "button2";
            button2.Size = new Size(130, 50);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // ItemsGroupBox
            // 
            ItemsGroupBox.Controls.Add(ItemsListBox);
            ItemsGroupBox.Controls.Add(button2);
            ItemsGroupBox.Controls.Add(button1);
            ItemsGroupBox.Location = new Point(0, 3);
            ItemsGroupBox.Name = "ItemsGroupBox";
            ItemsGroupBox.Size = new Size(344, 553);
            ItemsGroupBox.TabIndex = 3;
            ItemsGroupBox.TabStop = false;
            ItemsGroupBox.Text = "Items";
            // 
            // SelectedItemGroupBox
            // 
            SelectedItemGroupBox.Controls.Add(descriptionSelectedItemRichTextBox);
            SelectedItemGroupBox.Controls.Add(descriptionSelectedItemLable);
            SelectedItemGroupBox.Controls.Add(nameSelectedItemRichTextBox);
            SelectedItemGroupBox.Controls.Add(NameSelectedItemLable);
            SelectedItemGroupBox.Controls.Add(costSelectedItemTextBox);
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
            // descriptionSelectedItemRichTextBox
            // 
            descriptionSelectedItemRichTextBox.Location = new Point(6, 259);
            descriptionSelectedItemRichTextBox.Name = "descriptionSelectedItemRichTextBox";
            descriptionSelectedItemRichTextBox.Size = new Size(455, 96);
            descriptionSelectedItemRichTextBox.TabIndex = 7;
            descriptionSelectedItemRichTextBox.Text = "";
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
            // nameSelectedItemRichTextBox
            // 
            nameSelectedItemRichTextBox.Location = new Point(6, 133);
            nameSelectedItemRichTextBox.Name = "nameSelectedItemRichTextBox";
            nameSelectedItemRichTextBox.Size = new Size(455, 96);
            nameSelectedItemRichTextBox.TabIndex = 5;
            nameSelectedItemRichTextBox.Text = "";
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
            // costSelectedItemTextBox
            // 
            costSelectedItemTextBox.Location = new Point(49, 68);
            costSelectedItemTextBox.Name = "costSelectedItemTextBox";
            costSelectedItemTextBox.Size = new Size(100, 23);
            costSelectedItemTextBox.TabIndex = 3;
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
            ItemsGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox ItemsListBox;
        private Button button1;
        private Button button2;
        private GroupBox ItemsGroupBox;
        private GroupBox SelectedItemGroupBox;
        private TextBox costSelectedItemTextBox;
        private Label CostSelectedItemLabel;
        private Label IDSelectedItemLabel;
        private TextBox IDSelectedItemTextBox;
        private RichTextBox nameSelectedItemRichTextBox;
        private Label NameSelectedItemLable;
        private RichTextBox descriptionSelectedItemRichTextBox;
        private Label descriptionSelectedItemLable;
    }
}
