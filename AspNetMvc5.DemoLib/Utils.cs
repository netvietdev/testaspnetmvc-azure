using System;

namespace AspNetMvc5.DemoLib
{
    public class Utils
    {
        public static string GetDateTimeNow()
        {
            return "Server time now is " + DateTime.Now.ToString();
        }
    }
}
