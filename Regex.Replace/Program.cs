using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex.Replace
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length < 2) return;
            string pattern = args[0];
            string replacement = args[1];
            var rgx = new System.Text.RegularExpressions.Regex(pattern,
                RegexOptions.IgnoreCase | RegexOptions.Singleline);
            var sb = new StringBuilder();
            for (int c; ((c = Console.Read()) != -1);)
                sb.Append(Convert.ToChar(c));
            Console.Write(rgx.Replace(sb.ToString(), replacement));
        }
    }
}