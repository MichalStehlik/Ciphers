using System;
using System.Collections.Generic;
using System.Text;

namespace Cyphers
{
    public static class CipherExtensions
    {
        //Lowercase
        public static string Lowercase(this string text) 
        {
            return text.ToLower();
        }
        //Uppercase
        public static string Uppercase(this string text)
        {
            return text.ToUpper();
        }

        public static int CountChars(this string text, char letter)
        {
            int count = 0;
            foreach(char c in text)
            {
                if (c == letter) count++;
            }
            return count;
        }

        //Capitalize
        public static string Capitalize(this string text)
        {
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                char firstletter = Char.ToUpper(words[i][0]);
                string rest = words[i].Substring(1);
                words[i] = firstletter + rest.ToLower();
            }
            string result = String.Join(" ",words);
            return result;
        }

        //Cipher
        public static string Cipher(this string text, Func<Char,Char> processor)
        {
            string temp = "";
            char[] chars = text.ToCharArray();
            foreach (char c in chars)
            {
                temp = temp + processor(c);
            }
            return temp;
        }

        //Join
        public static string Join<T>(this List<T> source, string sep)
        {
            string temp = "";
            for (int i = 0; i < source.Count; i++)
            {
                temp = temp + source[i].ToString();
                if (i != source.Count - 1) temp = temp + sep;
            }
            return temp;
        }

        public static char ShiftBy2(char input)
        {
            return (char)((int)input + 2);
        }
    }
}
