namespace TestCore
{
    public static class StringExtenstion
    {
        public static string Truncate(this string value, int maxLength)
        {
            if (string.IsNullOrWhiteSpace(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }
    }
}
