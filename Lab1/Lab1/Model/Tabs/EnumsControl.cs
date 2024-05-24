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
    /// Класс, представляющий пользовательский элемент управления для работы с перечислениями.
    /// </summary>
    public partial class EnumsControl : UserControl
    {
        /// <summary>
        /// Конструктор по умолчанию для класса EnumsControl.
        /// </summary>
        public EnumsControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Обработчик события выбора элемента в списке перечислений.
        /// </summary>
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
        /// <summary>
        /// Попытка получения значения перечисления по его имени.
        /// </summary>
        /// <typeparam name="T">Тип перечисления.</typeparam>
        /// <param name="itemName">Имя элемента перечисления.</param>
        /// <param name="value">Возвращаемое значение перечисления.</param>
        /// <returns>Успешность получения значения перечисления.</returns>
        static public bool TryGetEnumValue<T>(string itemName, out T value) where T : struct
        {
            if (Enum.TryParse<T>(itemName, true, out value))
            {
                return true;
            }
            value = default;
            return false;
        }
        /// <summary>
        /// Метод для заполнения списка значений перечисления.
        /// </summary>
        private void FillingValuesListBox<T>()
        {
            Type enumType = typeof(T);
            foreach (var i in Enum.GetValues(enumType))
            {
                ValuesListBox.Items.Add(i);
            }
        }
        
        private void valuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Clear();
            IntValueTextBox.Text = ValuesListBox.SelectedIndex.ToString();
        }
    }
}
