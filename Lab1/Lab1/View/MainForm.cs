namespace Lab1
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void SeasonSwitch(object sender, EventArgs e)
        {
            switch (SeasoncomboBox.SelectedIndex)
            {
                case 0:
                    EnumsTabs.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case 1:
                    MessageBox.Show("���!������!");
                    break;
                case 2:
                    EnumsTabs.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
                case 3:
                    MessageBox.Show("����!�������!");
                    break;
            }
        }
        private void WeekDayParse(object sender, EventArgs e)
        {
            Weekday weekday;
            string temp = ValueForParsingTextBox.Text;
            if (!(temp == "") && !(temp == " "))
            {
                if (Enum.TryParse(temp, out weekday))
                {
                    ParseAnswerLabel.Text = $"���� ������:({weekday} = {(int)weekday})";
                }
                else
                {
                    ParseAnswerLabel.Text = "����������� ������� ������!";
                }
                if (Convert.ToInt32(temp) > 8)
                {
                    ParseAnswerLabel.Text = "������ ��� ������ �� ����������.";
                }
            }
            else
            {
                ParseAnswerLabel.Text = $"����������� ������� ������.";
            }
        }
        private void enumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            switch (EnumsListBox.SelectedIndex)
            {
                case 0:
                    FillingValuesListBox<Colors>();
                    break;
                case 1:
                    FillingValuesListBox<FormOfStudy>();
                    break;
                case 2:
                    FillingValuesListBox<Genre>();
                    break;
                case 3:
                    FillingValuesListBox<Season>();
                    break;
                case 4:
                    FillingValuesListBox<SmartphoneManufacturers>();
                    break;
                case 5:
                    FillingValuesListBox<Weekday>();
                    break;
            }
        }
        private void valuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Clear();
            IntValueTextBox.Text = ValuesListBox.SelectedIndex.ToString();
        }

        

        private void FillingValuesListBox<T>()
        {
            Type enumType = typeof(T);
            foreach (var i in Enum.GetValues(enumType))
            {
                ValuesListBox.Items.Add(i);
            }
        }

    }
}
