using System;
using System.Collections.Generic;

namespace Cyphers
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "Ahoj SVĚtE jak Se máš";
            Console.WriteLine(txt.Lowercase());
            //Console.WriteLine(Lowercase(txt));
            Console.WriteLine(txt.CountChars(' '));
            Console.WriteLine(txt.Capitalize());
            Console.WriteLine((new List<string> { "A", "B", "C"}).Join("+"));
            Console.WriteLine((new List<int> { 1, 2, 3 }).Join("+"));
            Console.WriteLine(txt.Cipher(
                (c) => { if (c == ' ') return '+'; else return c; }
            ));
            Console.WriteLine(txt.Cipher(
                (c) => { return (char)((int)c + 3); }
            ));
            Console.WriteLine(txt.Cipher(CipherExtensions.ShiftBy2));
        }
    }
}
