public class Order
{
    private int _id;
    private string _date;
    private Address _deliveryAddress;
    
    private double _amount;
    private OrderStatus _status;
    public int Id 
    {
        get; private set; 
    }
    public DateTime Date { get; set; }
    
    public Address DeliveryAddress 
    { 
        get 
        {  
            return _deliveryAddress; 
        } 
        set 
        { 
            _deliveryAddress = value;
        } 
    }
    public Cart Cart { get; set; }
    
    public double Amount
    {
        get
        {
            if (Cart.Items == null)
            {
                return 0.0;
            }

            double totalAmount = 0.0;
            foreach (Item item in Cart.Items)
            {
                totalAmount += item.Cost;
            }
            return totalAmount;


        }
        set { _amount = value; }

    }
    public OrderStatus Status
    {
        get;
        set;
    }
    public Order(Customer customer, double total)
    {
        Id = IdGenerator.GetNextId("Order");
        Date = DateTime.Now;
        DeliveryAddress = customer.Address;
        Cart = customer.Cart;
        Amount = Cart.Amount;
        Status = OrderStatus.New;
        Amount = total;
    }
    public Order()
    {
        Id = IdGenerator.GetNextId("Order");
        Date = DateTime.Now;
    }
}

