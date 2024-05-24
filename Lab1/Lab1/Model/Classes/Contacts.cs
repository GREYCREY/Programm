
using System.Text.RegularExpressions;

/// <summary>
/// Класс, представляющий контакт.
/// </summary>
class Contacts
{

    private string _name;
    private string _surname;
    private string _phoneNumber;
    /// <summary>
    /// Проверяет, содержит ли строка только буквы.
    /// </summary>
    /// <param name="value">Проверяемая строка.</param>
    /// <returns>Возвращает исходную строку, если она содержит только буквы.</returns>
    /// <exception cref="ArgumentException">Выбрасывается, если строка содержит символы, отличные от букв.</exception>
    private string AssertStringContainsOnlyLetters(string value)
    {
        
        if (!Regex.IsMatch(value, "[a-zA-Z0-9 ]*"))
        {
            return value;
        }
        else
        {
            throw new ArgumentException($"{value} is not correct");
        }
        
    }
    /// <summary>
    /// Имя контакта.
    /// </summary>
    /// <exception cref="ArgumentException">Выбрасывается, если значение содержит символы, отличные от букв.</exception>
    private string Name
    {
        get { return _name; }
        set
        {
            AssertStringContainsOnlyLetters(_name);
            
        }
        
    }
    
    /// <summary>
    /// Фамилия контакта.
    /// </summary>
    /// <exception cref="ArgumentException">Выбрасывается, если значение содержит символы, отличные от букв.</exception>
        private string Surname
    { 
        get { return _surname; }
        set
        {
            AssertStringContainsOnlyLetters(_surname);  
            
        }
    }
    /// <summary>
    /// Номер телефона контакта.
    /// </summary>
    /// <exception cref="ArgumentException">Выбрасывается, если значение пустое или длина больше 11 символов.</exception>
    private string PhoneNumber
    {
        get { return _phoneNumber; }
        set
        {
            if (value.Length == 0 && value.Length > 11) throw new ArgumentException();
            _phoneNumber = value;
        }
    }
    /// <summary>
    /// Конструктор по умолчанию.
    /// </summary>
    public Contacts()
    {
        Name = "Алексий";
        Surname = "Нечаев";
        PhoneNumber = "+88005353535";

    }
    /// <summary>
    /// Конструктор с параметрами.
    /// </summary>
    /// <param name="name">Имя контакта.</param>
    /// <param name="surname">Фамилия контакта.</param>
    /// <param name="phoneNumber">Номер телефона контакта.</param>
    public Contacts(string name, string surname, string phoneNumber)
    {
        Name = name;
        Surname = surname;
        PhoneNumber = phoneNumber;

    }

} 

