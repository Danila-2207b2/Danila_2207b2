class CustomConverter
{
    public bool Convert(string input, out int result)
    {
        return int.TryParse(input, out result);
    }

    public bool Convert(string input, out double result)
    {
        return double.TryParse(input, out result);
    }

    public bool Convert(string input, out bool result)
    {
        return bool.TryParse(input, out result);
    }

    public static void Main()
    {
        CustomConverter converter = new CustomConverter();
         
        if (converter.Convert("123", out int intValue))
        {
            Console.WriteLine($"int: {intValue}");
        }
        else
        {
            Console.WriteLine("Failed");
        }

        if (converter.Convert("123.45", out double doubleValue))
        {
            Console.WriteLine($" double: {doubleValue}");
        }
        else
        {
            Console.WriteLine("Failed.");
        }

        if (converter.Convert("true", out bool boolValue))
        {
            Console.WriteLine($"bool: {boolValue}");
        }
        else
        {
            Console.WriteLine("Failed");
        }
    }
}

