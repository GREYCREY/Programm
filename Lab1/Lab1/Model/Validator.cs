internal class Validator
{
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
    public static int AssertValueInRange(int value, int min, int max)
    {
        if (min < value && value < max)
        {
            return value;
        }
        else
        {
           throw new ArgumentException($"{value} is not correct!");
        } 


    }
    public static double AssertValueInRange(double value, double min, double max)
    {
        if (min < value && value < max)
        {
            return value;
        }
        else
        {
            throw new ArgumentException($"{value} is not correct!");
        }


    }
}
