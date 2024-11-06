public class Item
{
    /// <summary> 
    /// Хранит в себе порядковые номера товаров. 
    /// </summary> 
    private static int _allItemsCount;

    /// <summary> 
    /// Хранит в себе уникальный порядковый номер.  
    /// </summary> 
    private int _id;

    /// <summary> 
    /// Хранит в себе название товара. 
    /// </summary> 
    private string _name;

    /// <summary> 
    /// Хранит в себе информацию о товаре. 
    /// </summary> 
    private string _info;

    /// <summary> 
    /// Хранит в себе цену товара. 
    /// </summary> 
    private double _cost;

    /// <summary> 
    /// Возращает уникальный номер товара. 
    /// </summary> 
    public int Id { get; private set; }
    public Category Category { get; set; }

    /// <summary> 
    /// Возращает и задает название товара. 
    /// Задает через проверку при помощи класса <see cref="ValueValidator"/>. Значение должно быть не более 200. 
    /// </summary> 
    public string Name
    {
        get { return _name; }
        set { if (ValueValidator.AssertStringOnLength(value, 200, Name)) _name = value; }
    }

    /// <summary> 
    /// Возращает и задает информацию о товаре. 
    /// Задает через проверку при помощи класса <see cref="ValueValidator"/>. Значение должно быть не больше 1000. 
    /// </summary> 
    public string Info
    {
        get { return _info; }
        set { if (ValueValidator.AssertStringOnLength(value, 1000, Info)) _info = value; }
    }

    /// <summary> 
    /// Возращает и задает цену товара. 
    /// Задает через проверку при помощи класса <see cref="ValueValidator"/>. Значение должно быть в диапазоне от 0 до 100000. 
    /// </summary> 
    public double Cost
    {
        get { return _cost; }
        set { if (value > 0 && value < 100000) _cost = value; }
    }
    /// <summary> 
    /// Хранит данные о количестве покупателей. 
    /// </summary> 
    public static int AllItemsCount { get { return _allItemsCount; } }

    /// <summary> 
    /// Создает экземпляр класса <see cref="Item"/>. 
    /// </summary> 
    public Item()
    {
        Name = "Water";
        Info = "Used by people to drink ";
        Cost = 39.99;
        Category = Category.Food;
        Id = IdGenerator.GetNextId("Item");


    }

    /// <summary> 
    /// Создает экземпляр класса <see cref="Item"/>. 
    /// </summary> 
    /// <param name="name">Имя товара. Должно быть не длиннее 200 символов.</param> 
    /// <param name="info">Информация о товаре. Должна быть не длиннее 1000 символов.</param> 
    /// <param name="price">Цена товара. Должна быть в диапазоне от 0 до 100000.</param> 
    public Item(string name, string info, double cost, Category category)
    {
        Name = name;
        Info = info;
        Cost = cost;
        _id = ++_allItemsCount;
        Category = category;
        Id = IdGenerator.GetNextId("Item");

    }

}