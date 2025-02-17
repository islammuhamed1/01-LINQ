using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LINQ
{
    class CompareWithNonCaseSensitive : IComparer<string>
    {

        public int Compare(string? x, string? y)
        {
            return string.Compare(x, y,true);
        }

    }
}
