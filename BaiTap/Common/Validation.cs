using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common
{
    public class Validation
    {
        public static bool ContainsHtml(string input)
        {
            string htmlTagPattern = @"<.*?>";
            bool hasHtmlTags = Regex.IsMatch(input, htmlTagPattern);
            return hasHtmlTags;
        }
        public static bool ContainsSpecialChars(string input)
        {
            string specialCharPattern = @"[^a-zA-Z0-9\s]";
            bool hasSpecialChars = Regex.IsMatch(input, specialCharPattern);
            return hasSpecialChars;
        }
    }
}
