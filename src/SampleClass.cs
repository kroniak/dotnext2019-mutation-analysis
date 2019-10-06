using System;

namespace library
{
    public static class SampleClass
    {
        public static bool Method(bool a, bool b)
        {
            if (a && b) // mutate to ||
                return true;
            else 
                return false;
        }

        private static bool ExceptionMethod(int a)
        {
            if (a < 0)
                throw new ArgumentException("USER_DB is not path pattern user_adminXXXX", "user-name");

            return true;
        }

        public static string LibraryMethod(int a)
        {
            try
            {
                if (ExceptionMethod(a))
                    return "Successfully";
            }
            catch (ArgumentException e)
            {
                throw new Exception("Something happened", e);
            }

            return null;
        }

        public static int ForMethod()
        {
            var index = 0;
            while (index < 11)
            {
                index++;
                if (index == 10) // mutate to >=10  !=10    <10
                {
                    break;
                }
            }

            return index;
        }

        public static int Limit(int limit)
        {
            if (limit > 99) limit = 100;

            return limit;
        }
    }
}