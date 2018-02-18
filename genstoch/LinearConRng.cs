using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenStoch
{
    class LinearConRng
    {
        private const long a = 25214903917;
        private const long c = 11;
        private long seed;

        public LinearConRng(long seed)
        {
            if (seed < 0)
                throw new Exception("Bad seed");
            this.seed = seed;
        }

        private int next(int bits) // вспомогательный метод
        {
            seed = (seed * a + c) & ((1L << 48) - 1);
            return (int)(seed >> (48 - bits));
        }

        public double Next()
        {
            return (((long)next(26) << 27) + next(27)) / (double)(1L << 53);
        }
    }
}
