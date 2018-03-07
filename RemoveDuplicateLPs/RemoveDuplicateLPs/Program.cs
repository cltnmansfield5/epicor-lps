using System;
using System.Linq;

namespace RemoveDuplicateLPs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Somehow create array of LPs with same lot number - don't know Starlight software enough to do this
            string[] lps = { "X1", "X2", "X10", "X11", "X100", "X101" };
            //Remove LPs of smaller length
            Array.Sort(lps, (x, y) => x.Length.CompareTo(y.Length));

            int maxLength = lps[lps.Length - 1].Length;

            for (int i = 0; i < lps.Length; i++)
            {
                if (lps[i].Length < maxLength) {
                    // delete LP at lps[i]
                    lps = lps.Where(w => w != lps[i]).ToArray();
                }
            }
            //Of LPs remaining, sort alphabetically, then delete all but the last

            Array.Sort(lps);

            for (int i = 0; (i-1) < lps.Length; i++)
            {
                //delete LP at lps[i]
                lps = lps.Where(w => w != lps[i]).ToArray();
            }
        }
    }
}
