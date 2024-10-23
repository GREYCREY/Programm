public class Address
{
    private int _index;
    private string _country;
    private string _city;
    private string _street;
    private string _building;
    private string _apartment;

    public int Index
    {
        get { return _index; }
        set
        {
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
        Index = 821394;
        Country = "Kazahstan";
        City = "Semey";
        Street = "Proletarian";
        Building = "104";
        Apartment = "4";

    }
    public Address(int index, string country, string city, string street, string building, string apartment)
    {
        Index = index;
        Country = country;
        City = city;
        Street = street;
        Building = building;
        Apartment = apartment;
        
    }
}
