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
    public partial class RectanglesCollisionControl : UserControl
    {
        public RectanglesCollisionControl()
        {
            InitializeComponent();   
        }

        Rectangle[] _rectangles = new Rectangle[5];
        Rectangle _currentRectangle;
        List<Rectangle> _rectangleR = new List<Rectangle>();
        List<Panel> _rectanglePanels = new List<Panel>();
        Movie[] _movie = new Movie[5];
        Movie _currentMovie;
        private void TextBoxClassesRectangleY_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelOfXRectangle_Click(object sender, EventArgs e)
        {

        }

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            Rectangle newRectangle = СreatingRectangle.Randomize(1, panelOfRectangles.Width, panelOfRectangles.Height)[0];
            _rectangleR.Add(newRectangle);
            ListBoxOfRectangles.Items.Add($"{newRectangle.ID}. ({newRectangle.CenterOfRectangle} w = {newRectangle.Wight}; h = {newRectangle.Lenght})");

            Panel newPanel = new Panel();
            newPanel.BackColor = Color.FromArgb(127, 127, 255, 127);
            newPanel.Location = new Point((int)(newRectangle.CenterOfRectangle.X - newRectangle.Wight / 2), (int)(newRectangle.CenterOfRectangle.Y - newRectangle.Lenght / 2));
            newPanel.Width = (int)newRectangle.Wight;
            newPanel.Height = (int)newRectangle.Lenght;
            _rectanglePanels.Add(newPanel);
            panelOfRectangles.Controls.Add(newPanel);
            Collision();


        }
        private void Collision()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                _rectanglePanels[i].BackColor = Color.FromArgb(127, 127, 255, 127);
                for (int j = 0; j < _rectanglePanels.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangleR[i], _rectangleR[j]) && i != j)
                    {
                        _rectanglePanels[i].BackColor = Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }
        private void ChageTextElemListboxRectangle()
        {
            ListBoxOfRectangles.Items[ListBoxOfRectangles.SelectedIndex] = $"{_rectangleR[ListBoxOfRectangles.SelectedIndex].ID}. (" +
                 $"{_rectangleR[ListBoxOfRectangles.SelectedIndex].CenterOfRectangle} W = {_rectangleR[ListBoxOfRectangles.SelectedIndex].Wight}; " +
                 $"H = {_rectangleR[ListBoxOfRectangles.SelectedIndex].Lenght})";

        }

        private void ListBoxOfRectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxOfRectangles.SelectedIndex < 0)
            {
                textBoxlOfIDRectangle.Text = string.Empty;
                textBoxOfXRectangle.Text = string.Empty;
                textBoxOfYRectangle.Text = string.Empty;
                textBoxOfWidthRectangle.Text = string.Empty;
                textBoxOfLenghtRectangle.Text = string.Empty;

            }
            else
            {
                _currentRectangle = _rectangleR[ListBoxOfRectangles.SelectedIndex];
                textBoxlOfIDRectangle.Text = _currentRectangle.Wight.ToString();
                textBoxOfXRectangle.Text = _currentRectangle.CenterOfRectangle.X.ToString();
                textBoxOfYRectangle.Text = _currentRectangle.CenterOfRectangle.Y.ToString();
                textBoxOfWidthRectangle.Text = _currentRectangle.Wight.ToString();
                textBoxOfLenghtRectangle.Text = _currentRectangle.Lenght.ToString();


            }
        }

        private void RemoveRectanlgeButton_Click(object sender, EventArgs e)
        {
            if (ListBoxOfRectangles.SelectedIndex < 0) return;
            _rectangleR.RemoveAt(ListBoxOfRectangles.SelectedIndex);
            _rectanglePanels.RemoveAt(ListBoxOfRectangles.SelectedIndex);
            panelOfRectangles.Controls.RemoveAt(ListBoxOfRectangles.SelectedIndex);
            ListBoxOfRectangles.Items.RemoveAt(ListBoxOfRectangles.SelectedIndex);
            Collision();
        }

        private void textBoxOfXRectangle_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxOfXRectangle.Text)) return;
            try
            {
                int text = int.Parse(textBoxOfXRectangle.Text);
                _currentRectangle.CenterOfRectangle = new Point2D(text, _currentRectangle.CenterOfRectangle.Y);
                textBoxOfXRectangle.BackColor = Color.FromKnownColor(KnownColor.Window);
                ChageTextElemListboxRectangle();
                _rectanglePanels[ListBoxOfRectangles.SelectedIndex].Location = new Point(
                    text - _rectanglePanels[ListBoxOfRectangles.SelectedIndex].Width / 2,
                    _rectanglePanels[ListBoxOfRectangles.SelectedIndex].Location.Y);
                Collision();
            }
            catch (Exception)
            {
                textBoxOfXRectangle.BackColor = Color.LightPink;
            }
        }

        private void textBoxOfYRectangle_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxOfXRectangle.Text)) return;
            try
            {
                int text = int.Parse(textBoxOfYRectangle.Text);
                _currentRectangle.CenterOfRectangle = new Point2D(_currentRectangle.CenterOfRectangle.X, int.Parse(textBoxOfYRectangle.Text));
                textBoxOfYRectangle.BackColor = Color.FromKnownColor(KnownColor.Window);
                ChageTextElemListboxRectangle();
                _rectanglePanels[ListBoxOfRectangles.SelectedIndex].Location = new Point
                    (_rectanglePanels[ListBoxOfRectangles.SelectedIndex].Location.X, text - _rectanglePanels[ListBoxOfRectangles.SelectedIndex].Height / 2);
                Collision();
            }
            catch (Exception)
            {
                textBoxOfYRectangle.BackColor = Color.LightPink;
            }
        }

        private void textBoxOfWidthRectangle_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxOfWidthRectangle.Text)) return;
            try
            {
                int text = int.Parse(textBoxOfWidthRectangle.Text);
                _currentRectangle.Wight = text;
                textBoxOfWidthRectangle.BackColor = Color.FromKnownColor(KnownColor.Window);
                ChageTextElemListboxRectangle();
                _rectanglePanels[ListBoxOfRectangles.SelectedIndex].Width = text;
                Collision();
            }
            catch (Exception)
            {
                textBoxOfWidthRectangle.BackColor = Color.LightPink;
            }
        }

        private void textBoxOfLenghtRectangle_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxOfLenghtRectangle.Text)) return;
            try
            {
                int text = int.Parse(textBoxOfLenghtRectangle.Text);
                _currentRectangle.Lenght = text;
                textBoxOfLenghtRectangle.BackColor = Color.FromKnownColor(KnownColor.Window);
                ChageTextElemListboxRectangle();
                _rectanglePanels[ListBoxOfRectangles.SelectedIndex].Height = text;
                Collision();
            }
            catch (Exception)
            {
                textBoxOfLenghtRectangle.BackColor = Color.LightPink;
            }
        }
    }
}
