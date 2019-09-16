namespace LogTerminal.Infrastructure
{
    public static class StringExt
    {
        public static bool IsNotNullOrWhiteSpace(this string source)
        {
            return string.IsNullOrWhiteSpace(source) == false;
        }

    }
}
