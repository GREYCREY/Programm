
internal class Customer
 {  
    private static int _allCustomerCount;
    readonly int _id ;
    private string _fullname;
    private string _address;
    
    public int Id { get { return _id; } }
    public string FullName
    {
        get { return _fullname; }
        set { ValueValidator.LengthValidator(0, 200, value); _fullname = value; }
    }
    public string Address
    {
        get { return _address; }
        set { ValueValidator.LengthValidator(0, 500, value); _address = value; }
    }
    public static int AllCustomerCount { get { return _allCustomerCount; } }
    public Customer( string address, string fullName)
    {
        FullName = fullName;
        Address = address;
        _id = _allCustomerCount++;
        

    }
 }

