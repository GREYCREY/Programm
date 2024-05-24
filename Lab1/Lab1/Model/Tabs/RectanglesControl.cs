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
    public partial class RectanglesControl : UserControl
    {
        public RectanglesControl()
        {
            InitializeComponent();
            _rectangles = GetRandomRectangles(5);
            for (int i = 0; i < 5; i++)
            {
                RectangleListBox.Items.Add(_rectangles);
            }
        }
        Rectangle[] _rectangles = new Rectangle[5];
        Rectangle _currentRectangle;
        private Rectangle[] GetRandomRectangles(int size)
        {
            Rectangle[] myRectangles = new Rectangle[size];
            Random ran = new Random();

            for (int i = 0; i < size; i++)
            {
                myRectangles[i] = new Rectangle();
                myRectangles[i].Wight = ran.Next(10, 200);
                myRectangles[i].Lenght = ran.Next(10, 200);
                myRectangles[i].CenterOfRectangle = new Point2D(ran.Next(0, 528), ran.Next(0, 451));
            }

            return myRectangles;
        }
        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectangleListBox.SelectedItem == null) { return; }
            _currentRectangle = _rectangles[RectangleListBox.SelectedIndex];
            TextBoxClassesRectangleWidth.Text = _currentRectangle.Wight.ToString();
            TextBoxClassesRectangleLenght.Text = _currentRectangle.Lenght.ToString();
            TextBoxClassesRectangleColor.Text = _currentRectangle.ColorOfRectangle.ToString();
            TextBoxClassesRectangleX.Text = _currentRectangle.CenterOfRectangle.X.ToString();
            TextBoxClassesRectangleY.Text = _currentRectangle.CenterOfRectangle.Y.ToString();
            TextBoxClassesRectangleID.Text = _currentRectangle.ID.ToString();



        }
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            double MaxWidth = rectangles[0].Wight;
            int MaxWidthIndex = 0;
            for (int i = 0; i < 5; i++)
            {
                if (rectangles[i].Wight > MaxWidth)
                {
                    MaxWidth = rectangles[i].Wight;
                    MaxWidthIndex = i;
                }
            }
            return MaxWidthIndex;

        }

        static public bool TryGetEnumValue<T>(string itemName, out T value) where T : struct
        {
            if (Enum.TryParse<T>(itemName, true, out value))
            {
                return true;
            }
            value = default;
            return false;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null) return;
            if (TryGetEnumValue<Colors>(TextBoxClassesRectangleColor.Text, out Colors value))
            {
                _currentRectangle.ColorOfRectangle = value;
                TextBoxClassesRectangleColor.BackColor = System.Drawing.Color.White;
            }
            else
            {
                TextBoxClassesRectangleColor.BackColor = System.Drawing.Color.Pink;
            }
        }
        private void TextBoxClassesRectangleWidth_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBoxClassesRectangleWidth.BackColor = System.Drawing.Color.White;
                double wight = double.Parse(TextBoxClassesRectangleWidth.Text);
                _currentRectangle.Wight = wight;
            }
            catch
            {
                TextBoxClassesRectangleWidth.BackColor = System.Drawing.Color.LightPink;
            }

        }
        private void TextBoxClassesRectangleLenght_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBoxClassesRectangleLenght.BackColor = System.Drawing.Color.White;
                double lenght = double.Parse(TextBoxClassesRectangleLenght.Text);
                _currentRectangle.Wight = lenght;
            }
            catch
            {
                TextBoxClassesRectangleLenght.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void FindRectangle_Click(object sender, EventArgs e)
        {
             int rectangleWithMaxWidth = FindRectangleWithMaxWidth(_rectangles);
             RectangleListBox.SelectedIndex = rectangleWithMaxWidth;
             

        }
    }
}
