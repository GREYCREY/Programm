using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Item
    {
        readonly  int id = 0;
        private string _name;
        private string _info;
        private double _cost;
        

        public int ID => id; 
        
        public string Name
        {
            get { return _name; }
            set { ValueValidator.LengthValidator(0, 200, value); _name = value; }
        }
        public string Info
        {
            get { return _info; }
            set { ValueValidator.LengthValidator(0, 1000, value); _info = value; }
        }
        public double Cost
        {
            get { return _cost; }
            set { ValueValidator.CostValidator(0, 100000, value); _cost = value; }
        }
        public Item(string itemName, string itemInfo, double itemCost )
        {
            itemName = Name;
            itemInfo = Info;
            itemCost = Cost;
            id++;
        }
            
    }
