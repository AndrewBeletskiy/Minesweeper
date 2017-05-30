using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper.Additional
{
    public static class Rand
    {
        public static System.Random rand = new System.Random();

        public static int GetInt(int min, int max)
        {
            return rand.Next() % (max - min + 1) + min;
        }
    }
}
