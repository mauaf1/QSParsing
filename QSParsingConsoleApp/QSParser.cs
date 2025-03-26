namespace QSParsingConsoleApp
{
    public class QSParser
    {
        private readonly Dictionary<string, string> _parameters;

        public QSParser(string? queryString)
        {
            _parameters = new Dictionary<string, string>();

            if (!string.IsNullOrEmpty(queryString))
            {
                var pairs = queryString.Split('&', StringSplitOptions.RemoveEmptyEntries);

                foreach (var pair in pairs)
                {
                    var keyValue = pair.Split('=', 2);
                    if (keyValue.Length == 2)
                    {
                        _parameters[keyValue[0]] = keyValue[1];
                    }
                }
            }
        }

        public int Count()
        {
            return _parameters.Count;
        }

        public string? ValueOf(string key)
        {
            return _parameters.TryGetValue(key, out var value) ? value : null;
        }
    }
}
