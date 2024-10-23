namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            DeliveryAddressGroupBox = new GroupBox();
            CityTextBox = new TextBox();
            ApartmentTextBox = new TextBox();
            BuildingTextBox = new TextBox();
            StreetTextBox = new TextBox();
            CountryTextBox = new TextBox();
            PostIndexTextBox = new TextBox();
            ApatrmentLabel = new Label();
            BuildingLabel = new Label();
            CityLabel = new Label();
            StreetLabel = new Label();
            CountryLabel = new Label();
            PostIndexLabel = new Label();
            DeliveryAddressGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // DeliveryAddressGroupBox
            // 
            DeliveryAddressGroupBox.Controls.Add(CityTextBox);
            DeliveryAddressGroupBox.Controls.Add(ApartmentTextBox);
            DeliveryAddressGroupBox.Controls.Add(BuildingTextBox);
            DeliveryAddressGroupBox.Controls.Add(StreetTextBox);
            DeliveryAddressGroupBox.Controls.Add(CountryTextBox);
            DeliveryAddressGroupBox.Controls.Add(PostIndexTextBox);
            DeliveryAddressGroupBox.Controls.Add(ApatrmentLabel);
            DeliveryAddressGroupBox.Controls.Add(BuildingLabel);
            DeliveryAddressGroupBox.Controls.Add(CityLabel);
            DeliveryAddressGroupBox.Controls.Add(StreetLabel);
            DeliveryAddressGroupBox.Controls.Add(CountryLabel);
            DeliveryAddressGroupBox.Controls.Add(PostIndexLabel);
            DeliveryAddressGroupBox.Location = new Point(3, 3);
            DeliveryAddressGroupBox.Name = "DeliveryAddressGroupBox";
            DeliveryAddressGroupBox.Size = new Size(451, 144);
            DeliveryAddressGroupBox.TabIndex = 0;
            DeliveryAddressGroupBox.TabStop = false;
            DeliveryAddressGroupBox.Text = "Delivery Address:";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(262, 53);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(183, 23);
            CityTextBox.TabIndex = 11;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Location = new Point(262, 115);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(100, 23);
            ApartmentTextBox.TabIndex = 10;
            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Location = new Point(77, 115);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(100, 23);
            BuildingTextBox.TabIndex = 9;
            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
            // 
            // StreetTextBox
            // 
            StreetTextBox.Location = new Point(77, 86);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(368, 23);
            StreetTextBox.TabIndex = 8;
            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(77, 48);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(142, 23);
            CountryTextBox.TabIndex = 7;
            CountryTextBox.TextChanged += CountryTextBox_TextChanged;
            // 
            // PostIndexTextBox
            // 
            PostIndexTextBox.Location = new Point(77, 19);
            PostIndexTextBox.Name = "PostIndexTextBox";
            PostIndexTextBox.Size = new Size(100, 23);
            PostIndexTextBox.TabIndex = 6;
            PostIndexTextBox.TextChanged += PostIndexTextBox_TextChanged;
            // 
            // ApatrmentLabel
            // 
            ApatrmentLabel.AutoSize = true;
            ApatrmentLabel.Location = new Point(189, 123);
            ApatrmentLabel.Name = "ApatrmentLabel";
            ApatrmentLabel.Size = new Size(67, 15);
            ApatrmentLabel.TabIndex = 5;
            ApatrmentLabel.Text = "Apatrment:";
            // 
            // BuildingLabel
            // 
            BuildingLabel.AutoSize = true;
            BuildingLabel.Location = new Point(6, 123);
            BuildingLabel.Name = "BuildingLabel";
            BuildingLabel.Size = new Size(54, 15);
            BuildingLabel.TabIndex = 4;
            BuildingLabel.Text = "Building:";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(225, 56);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(31, 15);
            CityLabel.TabIndex = 3;
            CityLabel.Text = "City:";
            // 
            // StreetLabel
            // 
            StreetLabel.AutoSize = true;
            StreetLabel.Location = new Point(6, 94);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(40, 15);
            StreetLabel.TabIndex = 2;
            StreetLabel.Text = "Street:";
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Location = new Point(6, 56);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(53, 15);
            CountryLabel.TabIndex = 1;
            CountryLabel.Text = "Country:";
            // 
            // PostIndexLabel
            // 
            PostIndexLabel.AutoSize = true;
            PostIndexLabel.Location = new Point(6, 27);
            PostIndexLabel.Name = "PostIndexLabel";
            PostIndexLabel.Size = new Size(65, 15);
            PostIndexLabel.TabIndex = 0;
            PostIndexLabel.Text = "Post Index:";
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DeliveryAddressGroupBox);
            Name = "AddressControl";
            Size = new Size(457, 150);
            DeliveryAddressGroupBox.ResumeLayout(false);
            DeliveryAddressGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox DeliveryAddressGroupBox;
        private Label CountryLabel;
        private Label PostIndexLabel;
        private TextBox CityTextBox;
        private TextBox ApartmentTextBox;
        private TextBox BuildingTextBox;
        private TextBox StreetTextBox;
        private TextBox CountryTextBox;
        private TextBox PostIndexTextBox;
        private Label ApatrmentLabel;
        private Label BuildingLabel;
        private Label CityLabel;
        private Label StreetLabel;
    }
}
