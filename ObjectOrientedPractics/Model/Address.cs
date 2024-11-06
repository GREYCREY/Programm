using System.Reflection;

public class Address 
{
    private int _index;
    private string _country;
    private string _city;
    private string _street;
    private string _building;
    private string _apartament;

    public int Index
    {
        get { return _index; }

        set { if (ValueValidator.AssertStringOnLength(value.ToString(), 7, "Index") && value > 99999) { _index = value; } }
    }
    public string Country
    {
        get { return _country; }
        set { if (ValueValidator.AssertStringOnLength(value, 50, "Country")) { _country = value; } }
    }
    public string City
    {
        get { return _city; }
        set { if (ValueValidator.AssertStringOnLength(value, 50, "City")) { _city = value; } }
    }
    public string Street
    {
        get { return _street; }
        set { if (ValueValidator.AssertStringOnLength(value, 50, "Street")) { _street = value; } }
    }
    public string Building
    {
        get { return _building; }
        set { if (ValueValidator.AssertStringOnLength(value, 50, "Building")) { _building = value; } }
    }
    public string Apartment
    {
        get { return _apartament; }
        set { if (ValueValidator.AssertStringOnLength(value, 50, "Apartament")) { _apartament = value; } }
    }
    public Address()
    {
        Index = 123456;
        Country = "Россия";
        City = "Томск";
        Street = "Пр. Ленина";
        Building = "40";
        Apartment = "112";
    }
    public Address(int index, string country, string city, string street, string building, string apartament)
    {
        Index = index;
        Country = country;
        City = city;
        Street = street;
        Building = building;
        Apartment = apartament;
    }
    public object Clone()
    {
        return new Address(Index, Country, City, Street, Building, Apartment);
    }

    
}