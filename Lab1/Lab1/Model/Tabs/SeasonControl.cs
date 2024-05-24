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
    /// <summary>
    /// Класс, представляющий элемент управления для выбора сезона.
    /// </summary>
    public partial class SeasonControl : UserControl
    {
        /// <summary>
        /// Конструктор класса SeasonControl.
        /// </summary>
        public SeasonControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Обработчик события переключения сезона.
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void SeasonSwitch(object sender, EventArgs e)
        {
            switch (SeasoncomboBox.SelectedIndex)
            {
                case 0:
                    SeasoncomboBox.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case 1:
                    MessageBox.Show("Ура!Солнце!");
                    break;
                case 2:
                    SeasoncomboBox.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
                case 3:
                    MessageBox.Show("Бррр!Холодно!");
                    break;
            }
        }
    }
}
