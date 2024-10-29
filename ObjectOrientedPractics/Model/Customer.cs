/// <summary>
/// Класс, представляющий информацию о клиенте.
/// </summary>
public class Customer
{
    /// <summary>
    /// Статическое поле, хранящее количество всех клиентов.
    /// </summary>
    private static int _allCustomerCount;

    /// <summary>
    /// Уникальный идентификатор клиента (только для чтения).
    /// </summary>
    readonly int _id;

    /// <summary>
    /// Полное имя клиента.
    /// </summary>
    private string _fullname;

    /// <summary>
    /// Адрес клиента.
    /// </summary>
    private Address _address;

    /// <summary>
    /// Получает уникальный идентификатор клиента.
    /// </summary>
    public int Id { get { return _id; } }

    /// <summary>
    /// Получает или задает полное имя клиента.
    /// Проводит проверку длины строки (не более 200 символов).
    /// </summary>
    public string FullName
    {
        get { return _fullname; }
        set { ValueValidator.LengthValidator(0, 200, value); _fullname = value; }
    }

    /// <summary>
    /// Получает или задает адрес клиента.
    /// Проводит проверку длины строки (не более 500 символов).
    /// </summary>
    public Address Address
    {
        get { return _address; }
        set { _address = value; }
    }

    /// <summary>
    /// Получает общее количество клиентов.
    /// </summary>
    public static int AllCustomerCount { get { return _allCustomerCount; } }

    /// <summary>
    /// Конструктор, инициализирующий новый экземпляр класса Customer.
    /// Устанавливает адрес и полное имя клиента и назначает уникальный идентификатор.
    /// </summary>
    /// <param name="address">Адрес клиента.</param>
    /// <param name="fullName">Полное имя клиента.</param>
    public Customer(Address address, string fullName)
    {
        FullName = fullName;
        Address = address;
        _id = _allCustomerCount++;
    }
    public Customer()
    {
        FullName = "Alex";
        Address = new Address();
        _id = _allCustomerCount++;
    }
}
