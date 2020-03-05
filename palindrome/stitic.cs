using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace palindrome
{
    public static class stitic
    {
        public static bool Check(string a)

            {
                var pal = a.Reverse().Select(i => i);
                var str = "";
                foreach (var q in pal)
                {
                    str += q;
                }

            if (a == str)
            {
                return true;
            }

            else
            {
                return false;
            }

            }
        
    }
}
