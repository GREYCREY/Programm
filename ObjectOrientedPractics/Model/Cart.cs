public class Cart 
{
    public List<Item> Items { get; set; }

    public double Amount
    {
        get
        {
            double amount = 0;
            if (Items != null)
            {
                for (int i = 0; i < Items.Count; i++)
                {
                    amount += Items[i].Cost;
                }
            }
            return amount;
        }
    }
    public Cart()
    {
        Items = new List<Item>(5);
    }
    public object Clone()
    {
        Cart copy = new();
        copy.Items.AddRange([.. Items]);
        return copy;
    }
}
