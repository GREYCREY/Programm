﻿public class Cart
{

    private List<Item> _items = new List<Item>();
    public List<Item> Items
    {
        get { return _items; }
        set { _items = value; }
    }
    public double Amount
    {
        get
        {
            if (_items == null || _items.Count == 0)
            {
                return 0.0;
            }

            double totalAmount = 0.0;
            foreach (Item item in _items)
            {
                totalAmount += item.Cost;
            }
            return totalAmount;


        }

    }



}