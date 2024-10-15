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
            PostIndexLabel = new Label();
            CountryLabel = new Label();
            StreetLabel = new Label();
            CityLabel = new Label();
            BuildingLabel = new Label();
            ApatrmentLabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            DeliveryAddressGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // DeliveryAddressGroupBox
            // 
            DeliveryAddressGroupBox.Controls.Add(textBox6);
            DeliveryAddressGroupBox.Controls.Add(textBox5);
            DeliveryAddressGroupBox.Controls.Add(textBox4);
            DeliveryAddressGroupBox.Controls.Add(textBox3);
            DeliveryAddressGroupBox.Controls.Add(textBox2);
            DeliveryAddressGroupBox.Controls.Add(textBox1);
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
            // PostIndexLabel
            // 
            PostIndexLabel.AutoSize = true;
            PostIndexLabel.Location = new Point(6, 27);
            PostIndexLabel.Name = "PostIndexLabel";
            PostIndexLabel.Size = new Size(65, 15);
            PostIndexLabel.TabIndex = 0;
            PostIndexLabel.Text = "Post Index:";
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
            // StreetLabel
            // 
            StreetLabel.AutoSize = true;
            StreetLabel.Location = new Point(6, 94);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(40, 15);
            StreetLabel.TabIndex = 2;
            StreetLabel.Text = "Street:";
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
            // BuildingLabel
            // 
            BuildingLabel.AutoSize = true;
            BuildingLabel.Location = new Point(6, 123);
            BuildingLabel.Name = "BuildingLabel";
            BuildingLabel.Size = new Size(54, 15);
            BuildingLabel.TabIndex = 4;
            BuildingLabel.Text = "Building:";
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
            // textBox1
            // 
            textBox1.Location = new Point(77, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(77, 48);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(142, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(77, 86);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(368, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(77, 115);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(262, 115);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(262, 53);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(183, 23);
            textBox6.TabIndex = 11;
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
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label ApatrmentLabel;
        private Label BuildingLabel;
        private Label CityLabel;
        private Label StreetLabel;
    }
}
