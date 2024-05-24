/// <summary>
/// Класс, содержащий методы для проверки значений.
/// </summary>
internal class Validator
{
    /// <summary>
    /// Проверяет, является ли значение положительным.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <returns>Возвращает значение, если оно положительное.</returns>
    /// <exception cref="ArgumentException">Выбрасывается, если значение меньше 0.</exception>
    public static int AssertOnPositiveValue(int value)
    {
        if (value < 0)
        {
            throw new ArgumentException($"{value} is not correct");
        }
        else
        {
            return value;
        }

    }
    /// <summary>
    /// Проверяет, является ли значение положительным.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <returns>Возвращает значение, если оно положительное.</returns>
    /// <exception cref="ArgumentException">Выбрасывается, если значение меньше 0.</exception>
    public static double AssertOnPositiveValue(double value)
    {
        if (value < 0)
        {
            throw new ArgumentException($"{value} is not correct");
        }
        else
        {
            return value;
        }

    }
    /// <summary>
    /// Проверяет, находится ли значение в заданном диапазоне.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <param name="min">Минимальное допустимое значение.</param>
    /// <param name="max">Максимальное допустимое значение.</param>
    /// <returns>Возвращает значение, если оно находится в диапазоне.</returns>
    /// <exception cref="ArgumentException">Выбрасывается, если значение не находится в диапазоне.</exception>
    public static int AssertValueInRange(int value, int min, int max)
    {
        if (min <= value && value <= max)
        {
            return value;
        }
        else
        {
           throw new ArgumentException($"{value} is not correct!");
        } 


    }
    /// <summary>
    /// Проверяет, находится ли значение в заданном диапазоне.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <param name="min">Минимальное допустимое значение.</param>
    /// <param name="max">Максимальное допустимое значение.</param>
    /// <returns>Возвращает значение, если оно находится в диапазоне.</returns>
    /// <exception cref="ArgumentException">Выбрасывается, если значение не находится в диапазоне.</exception>
    public static double AssertValueInRange(double value, double min, double max)
    {
        if (min <= value && value <= max)
        {
            return value;
        }
        else
        {
            throw new ArgumentException($"{value} is not correct! {nameof(value)}");
        }


    }
}
