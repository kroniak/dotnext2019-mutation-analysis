using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// ReSharper disable ParameterOnlyUsedForPreconditionCheck.Local
// ReSharper disable CollectionNeverUpdated.Local
// ReSharper disable ConvertIfStatementToReturnStatement
// ReSharper disable once InconsistentNaming

namespace library
{
    public static class SampleClass
    {
        private const int MAX_URL_LENGTH = 1;

        public static bool Method(bool a, bool b)
        {
            if (a && b)
                return true;

            return false;
        }

        public static string Encode(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return s;

            if (s.Length > MAX_URL_LENGTH)
                // ... other actions with s

                return s;

            return s;
        }

        private static bool ExceptionMethod(bool con)
        {
            if (!con)
                throw new ArgumentException("USER_DB is not path pattern user_adminXXXX",
                    nameof(con));

            return true;
        }

        public static string LibraryMethod(bool con)
        {
            try
            {
                if (ExceptionMethod(con))
                    return "Successfully";
            }
            catch (ArgumentException e)
            {
                throw new Exception("Something happened", e);
            }

            return string.Empty;
        }

        public static int ForMethod()
        {
            var index = 0;
            while (true)
            {
                index++;
                if (index == 10) // mutate to >=10  !=10    <10
                    break;
            }

            return index;
        }

        public static int Limit(int limit)
        {
            if (limit < 0)
                throw new ArgumentException("Limit must be greater than 0", nameof(limit));

            if (limit > 99) limit = 100;

            return limit;
        }

        public static void Some<T>(object arg, IEnumerable<T> list)
        {
            // ...
            var result = new List<T>();
            // ...

            if (result.FirstOrDefault() != null)
            {
                // ...
            }

            // ...
        }

        public static async Task<string?> GetValueAsync(string url)
        {
            var values = await GetFromUrlAsync(url);

            // ... other work

            return values.FirstOrDefault();
        }

        private static Task<string[]> GetFromUrlAsync(string url)
        {
            return Task.FromResult(new[] {url});
        }
    }
}