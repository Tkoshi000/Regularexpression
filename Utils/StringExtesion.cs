using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regularexpression.Utils
{
    public class StringExtesion
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="patern"></param>
        /// <returns></returns>
        public string RegexExtension(string input,string patern) {
            ///正規化
            var Match = Regex.Match(input, patern);

            if (Match.Success == true)
            {
                return input;
            }
            return "";
        }
    }
}
