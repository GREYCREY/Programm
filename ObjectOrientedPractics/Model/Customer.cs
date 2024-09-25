/// <summary>
/// Класс, представляющий информацию о клиенте.
/// </summary>
internal class Customer
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
    private string _address;

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
    public string Address
    {
        get { return _address; }
        set { ValueValidator.LengthValidator(0, 500, value); _address = value; }
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
    public Customer(string address, string fullName)
    {
        FullName = fullName;
        Address = address;
        _id = _allCustomerCount++;
    }
}
