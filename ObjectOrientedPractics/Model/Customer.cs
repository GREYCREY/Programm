using System.Security.Cryptography.X509Certificates;


/// <summary>
/// Класс, представляющий информацию о клиенте.
/// </summary>
public class Customer
{
    /// <summary>
    /// Статическое поле, хранящее количество всех клиентов.
    /// </summary>

    /// <summary>
    /// Уникальный идентификатор клиента (только для чтения).
    /// </summary>

    /// <summary>
    /// Полное имя клиента.
    /// </summary>
    private string _fullname;

    /// <summary>
    /// Адрес клиента.
    /// </summary>
    private Address _address = new Address();
    private Cart _cart = new Cart();
    private List<Item> _itemsList=  new List<Item>();
    private List<Order> _ordersList = new List<Order>() ;
    public List<Order> OrdersList
    {
        get { return _ordersList; }
        set { _ordersList = value; }
    }
    public List<Item> ItemsList
    {
        get { return _itemsList; }
        set { _itemsList = value; }
    }
    public Cart Cart
    {
        get { return _cart; }
        set { _cart = value; }
    }

    /// <summary>
    /// Получает уникальный идентификатор клиента.
    /// </summary>

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
    public int Id { get; private set; }

    /// <summary>
    /// Получает общее количество клиентов.
    /// </summary>

    /// <summary>
    /// Конструктор, инициализирующий новый экземпляр класса Customer.
    /// Устанавливает адрес и полное имя клиента и назначает уникальный идентификатор.
    /// </summary>
    /// <param name="address">Адрес клиента.</param>
    /// <param name="fullName">Полное имя клиента.</param>
    List<Cart> carts = new List<Cart>();
    public Customer(Address address, string fullName, Cart cart, List<Item> itemsList, List<Order> ordersList)
    {
        FullName = fullName;
        Address = address;
        Cart = cart;
        _ordersList = ordersList;
        OrdersList = ordersList;
    }
    public Customer()
    {
        FullName = "Alex";
        Address = new Address();

        Id = IdGenerator.GetNextId("Customer");
    }
}
