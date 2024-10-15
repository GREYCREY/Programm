/// <summary>
/// Класс для валидации различных значений.
/// </summary>
class ValueValidator
{
    /// <summary>
    /// Проверяет, что длина строки находится в пределах заданного диапазона.
    /// </summary>
    /// <param name="minLength">Минимальная допустимая длина строки.</param>
    /// <param name="maxLength">Максимальная допустимая длина строки.</param>
    /// <param name="value">Строка для проверки.</param>
    /// <returns>Возвращает строку, если её длина находится в пределах допустимого диапазона.</returns>
    /// <exception cref="ArgumentException">Выбрасывается, если длина строки не соответствует заданным параметрам.</exception>
    public static  string LengthValidator(int minLength, int maxLength, string value)
    {
        if (value.Length > minLength && value.Length < maxLength) { return value; }
        else { throw new ArgumentException(nameof(value)); }
    }

    /// <summary>
    /// Проверяет, что значение стоимости находится в пределах заданного диапазона.
    /// </summary>
    /// <param name="minCost">Минимально допустимая стоимость.</param>
    /// <param name="maxCost">Максимально допустимая стоимость.</param>
    /// <param name="value">Значение стоимости для проверки.</param>
    /// <returns>Возвращает значение стоимости, если оно находится в пределах допустимого диапазона.</returns>
    /// <exception cref="ArgumentException">Выбрасывается, если стоимость не соответствует заданным параметрам.</exception>
    public static double CostValidator(double minCost, double maxCost, double value)
    {
        if (value > minCost && value < maxCost) { return value; }
        else { throw new ArgumentException(nameof(value)); }
    }
    public static int IntValueValidator(int minValue, int maxValue, int value)
    {
        if (value > minValue && value < maxValue) { return value; }
        else { throw new ArgumentException(nameof(value)); }
    }
}
