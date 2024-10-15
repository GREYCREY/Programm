public class Address
{
    private short _index;
    private string _country;
    private string _city;
    private string _street;
    private string _building;
    private string _apartment;

    public short Index
    {
        get { return _index; }
        set
        {
            ValueValidator.IntValueValidator(100000, 999999, _index);
            _index = value;
        }
    }
    public string Country
    {
        get { return _country; }
        set
        {
            ValueValidator.LengthValidator(1, 50, value);
            _country = value;

        }
    }
    public string City
    {
        get { return _city; }
        set 
        { 
            ValueValidator.LengthValidator(1, 50, value);
              _city = value;

        }
    }
    public string Street
    {
        get { return _street; }
        set 
        { 
            ValueValidator.LengthValidator(1, 100, value);
            _street = value;
        
        }
    }
    public string Building
    {
        get { return _building; }
        set 
        { 
            ValueValidator.LengthValidator(1, 10, value);
            _building = value;
        
        }
    }
    public string Apartment
    {
        get { return _apartment; }
        set 
        { 
            ValueValidator.LengthValidator(1, 10, value);
            _apartment = value;

        }
    }
    public Address()
    {
        Index = 0;
        Country = "Kazahstan";
        City = "Semey";
        Street = "Proletarian";
        Building = "104";
        Apartment = "4";

    }
    public Address(short index, string country, string city, string street, string building, string apartment)
    {
        Index = index;
        Country = country;
        City = city;
        Street = street;
        Building = building;
        Apartment = apartment;
        
    }
}
