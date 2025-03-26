namespace QSParsingConsoleApp
{
    public class QSParser
    {
        // Example: count how many key-value pairs are in a query string
        public int Count(string queryString)
        {
            if (string.IsNullOrWhiteSpace(queryString))
                return 0;

            // Remove leading '?' if present
            if (queryString.StartsWith("?"))
                queryString = queryString.Substring(1);

            var pairs = queryString.Split('&', System.StringSplitOptions.RemoveEmptyEntries);
            return pairs.Length;
        }
    }
}
