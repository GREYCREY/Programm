public class Order
{
    readonly int _id;
    private string _date;
    private string _diliveryAddress;
    private List<Item> _itemsList;
    private double _amount;
    public int Id 
    { 
        get { return _id; } 
    }
    public string Date 
    { 
        get 
        { 
            return _date; 
        } 
        set 
        {  
            _date = value; 
        } 
    }
    public string DiliveryAddress 
    { 
        get 
        {  
            return _diliveryAddress; 
        } 
        set 
        { 
            _diliveryAddress = value;
        } 
    }
    public List<Item> ItemsList 
    { 
        get 
        { 
            return _itemsList; 
        }
        
        set 
        {
            _itemsList = value; 
        } 
    }
    public double Amount
    {
        get
        {
            if (_itemsList == null || _itemsList.Count == 0)
            {
                return 0.0;
            }

            double totalAmount = 0.0;
            foreach (Item item in _itemsList)
            {
                totalAmount += item.Cost;
            }
            return totalAmount;


        }

    }
}

