static class ValueValidator
{
    /// <summary>
    /// Проверяет, не превышает ли длина строки заданное максимальное значение.
    /// В случае превышения выбрасывает исключение.
    /// </summary>
    /// <param name="value">Строка для проверки.</param>
    /// <param name="maxLenght">Максимально допустимая длина.</param>
    /// <param name="propertyName">Название свойства, в котором вызван метод.</param>
    /// <returns>True, если длина строки меньше maxLenght; в противном случае выбрасывается исключение.</returns>
    /// <exception cref="ArgumentException">Выбрасывается, если длина строки превышает maxLenght.</exception>
    public static bool AssertStringOnLength(string value, int maxLenght, string propertyName)
    {
        propertyName = nameof(propertyName);
        if (value.Length >= maxLenght)
        {
            throw new ArgumentException($"{propertyName} должен быть меньше {maxLenght}символов");
        }
        else
        {
            return true;
        }
    }
    public static bool AssertOnValue(int value, int maxValue, string propertyName)
    {
        propertyName = nameof(propertyName);
        if (value < 0 || value > maxValue)
        {
            throw new ArgumentException($"{propertyName} должен быть меньше {maxValue}");
        }
        else
        {
            return true;
        }
    }
    public static bool AssertOnPositiveValue(int value, string propertyName)
    {
        if (value >= 0)
        {
            return true;
        }
        else
        {
            throw new ArgumentException($"{propertyName} должен быть больше 0");
        }
    }
}