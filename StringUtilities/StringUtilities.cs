using System;
using System.Text.RegularExpressions;
using System.Collections;

namespace StringUtilities
{
    public static class StringUtilities
    {
        public static bool IsUniqueCharacterSet(this string s)
        {
            // remove all space chars from string
            var cleanString = Regex.Replace(s, @"[\s+]", "").ToLower();

            // make a hash table/set
/*            Hashtable my_hashtable1 = new Hashtable();
            int num = 1;
            foreach ( char c in cleanString)
            {
                my_hashtable1.Add(c, num);
                num++;
            }
            foreach (var item in my_hashtable1)
            {

            }*/
                

            return false;
        }
    }
}
