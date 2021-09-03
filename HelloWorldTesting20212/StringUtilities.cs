using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorldTesting20212
{
    class StringUtilities
    {
        public bool EsPalindrome(string word)
        {
            var invertido = word.ToCharArray().Reverse().ToString();
            return word ==invertido;
        }
    }
}
