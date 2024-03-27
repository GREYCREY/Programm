
using System.Text.RegularExpressions;

class Contacts
{

    private string _name;
    private string _surname;
    private string _phoneNumber;
    private string AssertStringContainsOnlyLetters(string value)
    {
        bool answer = false;
        if (!Regex.IsMatch(value, "[a-zA-Z0-9 ]*"))
        {
            return value;
        }
        else
        {
            throw new ArgumentException($"{value} is not correct");
        }
        
    }
    private string Name
    {
        get { return _name; }
        set
        {
            AssertStringContainsOnlyLetters(_name);
            
        }
        
    }


        private string Surname
    { 
        get { return _surname; }
        set
        {
            AssertStringContainsOnlyLetters(_surname);  
            
        }
    }
    private string PhoneNumber
    {
        get { return _phoneNumber; }
        set
        {
            if (value.Length == 0 && value.Length > 11) throw new ArgumentException();
            _phoneNumber = value;
        }
    }
    public Contacts()
    {
        Name = "Алексий";
        Surname = "Нечаев";
        PhoneNumber = "+88005353535";

    }
    public Contacts(string name, string surname, string phoneNumber)
    {
        Name = name;
        Surname = surname;
        PhoneNumber = phoneNumber;

    }

} 

