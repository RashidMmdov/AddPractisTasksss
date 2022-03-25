using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika_OddAndEen
{
    internal class CheckNumber
    {
        public bool isOdd(int num)
        {
            bool Check = false;
            if (num % 2 == 1)
            {
                Check = true;
            }
            return Check;
        }
        public bool isEven(int num)
        {
            bool Check = false;
            if (num % 2 == 0)
            {
                Check = true;
            }
            return Check;
        }
    }
}
