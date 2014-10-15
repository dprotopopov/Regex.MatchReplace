using System;
using System.Text;

namespace Regex.Unescape
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var sb = new StringBuilder();
            for (int c; ((c = Console.Read()) != -1);)
                sb.Append(Convert.ToChar(c));
            Console.Write(System.Text.RegularExpressions.Regex.Unescape(sb.ToString()));
        }
    }
}