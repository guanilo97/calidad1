using System;

namespace HelloWorldTesting20212
{
    class Program
    {
        static void Main(string[] args)
        {
            var utils = new StringUtilities();
            string texto = Console.ReadLine();
            bool palindrome = utils.EsPalindrome(texto);
            if (palindrome)
            {
                Console.WriteLine("es palindrome");
            }
            else
            {
                Console.WriteLine("no es");
            }
            
        }
    }
}
