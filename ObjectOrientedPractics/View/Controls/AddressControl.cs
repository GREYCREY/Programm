using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        public AddressControl()
        {
            InitializeComponent();
        }


        private Address _address;
        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PostIndexTextBox.BackColor = Color.White;
                _address.Index = Convert.ToInt32(PostIndexTextBox.Text);

            }
            catch (Exception)
            {
                PostIndexTextBox.BackColor = Color.LightPink;
            }

        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CountryTextBox.BackColor = Color.White;
                _address.Country = CountryTextBox.Text;

            }
            catch (Exception)
            {
                PostIndexTextBox.BackColor = Color.LightPink;
            }

        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CityTextBox.BackColor = Color.White;
                _address.City = CityTextBox.Text;

            }
            catch (Exception)
            {
                PostIndexTextBox.BackColor = Color.LightPink;
            }

        }

        private void SreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                StreetTextBox.BackColor = Color.White;
                _address.Street = StreetTextBox.Text;

            }
            catch (Exception)
            {
                PostIndexTextBox.BackColor = Color.LightPink;
            }


        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BuildingTextBox.BackColor = Color.White;
                _address.Building = BuildingTextBox.Text;

            }
            catch (Exception)
            {
                PostIndexTextBox.BackColor = Color.LightPink;
            }

        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ApartmentTextBox.BackColor = Color.White;
                _address.Apartment = ApartmentTextBox.Text;

            }
            catch (Exception)
            {
                PostIndexTextBox.BackColor = Color.LightPink;
            }

        }
        public Address Address
        {
            get { return _address; }
            set
            {
                if (_address != null || value != null)
                {
                    _address = value;
                    
                    PostIndexTextBox.Text = _address.Index.ToString();
                    CityTextBox.Text = _address.City;
                    CountryTextBox.Text = _address.Country;
                    BuildingTextBox.Text = _address.Building;
                    ApartmentTextBox.Text = _address.Apartment;
                    StreetTextBox.Text = _address.Street;
                }
            }
        }

    }
}
