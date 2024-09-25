    class ValueValidator
    {
        public static string LengthValidator(int minLength, int maxLength, string value)
        {
            if (value.Length > minLength && value.Length < maxLength) { return value; }
            else { throw new ArgumentException(nameof(value)); }
        }
        public static double CostValidator(double minCost, double maxCost, double value)
        {
            if (value > minCost && value < maxCost) { return value; }
            else { throw new ArgumentException(nameof(value)); }
        }
    }

