using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1.Model.Tabs
{
    public partial class WeekDayControl : UserControl
    {
        public WeekDayControl()
        {
            InitializeComponent();
        }
        private void WeekDayParse(object sender, EventArgs e)
        {
            Weekday weekday;
            var temp = ValueForParsingTextBox.Text;
            int examination;
            bool isInt;
            if (!(temp == "") && !(temp == " "))
            {
                if (Enum.TryParse(temp, out weekday))
                {
                    ParseAnswerLabel.Text = $"День недели:({weekday} = {(int)weekday})";
                }
                else
                {
                    ParseAnswerLabel.Text = "Некорректно введены данные!";
                }
                isInt = int.TryParse(temp, out examination);
                if (isInt)
                {
                    ParseAnswerLabel.Text = "Введите название дня текстом.";
                }
            }
            else
            {
                ParseAnswerLabel.Text = $"Некорректно введены данные.";
            }
        }

        private void ValueForParsingTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
