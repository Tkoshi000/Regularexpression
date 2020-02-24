using Regularexpression.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regularexpression
{
    class Program
    {
        static void Main(string[] args)
        {
            ///123
            ///@\d
            ///
            if (args.Count() == 2)
            {
                var input = args[0];
                var patern = args[1];
                StringExtesion se = new StringExtesion();
                var output = se.RegexExtension(input, patern);
                Console.WriteLine(output);
            }
            else if (args.Count() == 1)
            {
                if (args[0] == "/help")
                {
                    Console.WriteLine("exe input patern (replace)");
                }
            }
            else
            {
                Console.WriteLine("exe input patern (replace)");
            }
        }
    }
}
