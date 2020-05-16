using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyConcepts
{
    public static class ExtensionMethods
    {
        public static string ToReverseString(this string str)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string reversedstring = new string(charArray);
            
            return reversedstring;
        }

        public static string ToReverseStringUsingStack(this string mystring)
        {

            var stack = new Stack<char>(mystring);
            var array = new char[stack.Count];

            int i = 0;
            while (stack.Count != 0)
            {
                array[i++] = stack.Pop();
            }
            return new string(array);
        }

        public static string ToReverseStringManual(this string mystring)
        {
            char[] charArray = mystring.ToCharArray();
            int len = charArray.Length-1;
            int mid = len / 2;

            for (int i = 0; i < mid; i++)
            {
                char tmp = charArray[i];
                charArray[i] = charArray[len - i];
                charArray[len - i] = tmp;

            }

            return new string(charArray);
        }


    }
}
