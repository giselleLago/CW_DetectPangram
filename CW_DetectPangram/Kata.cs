using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CW_DetectPangram
{
    public class Kata
    {
        public bool IsPangram(string str)
        {
            return str.Where(ch => Char.IsLetter(ch)).Select(ch => Char.ToLower(ch)).Distinct().Count() == 26;
        }
    }
}
