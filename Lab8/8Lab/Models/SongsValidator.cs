internal class SongsValidator
{
    /// <summary>
    /// Проверка текста на допустимую длину.
    /// </summary>
    /// <param name="minLength">Минимальная длина.</param>
    /// <param name="maxLength">Максимальная длина.</param>
    /// <param name="value">Проверяемое значение.</param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static string LengthValidator(int minLength, int maxLength, string value)
    {
        if (value.Length > minLength && value.Length < maxLength) { return value; }
        else { throw new ArgumentException(nameof(value)); }
    }
    public static int DurationValidator(int minDuration, int maxDuration, int value)
    {
        if (value > minDuration && value < maxDuration) { return value; }
        else { throw new ArgumentException(nameof(value)); }
    }
}
