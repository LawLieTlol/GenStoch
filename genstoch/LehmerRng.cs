using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenStoch
{
    class LehmerRng
    {
        /// <summary>
        /// Пояснение работы алгоритма
        /// X(i) = a * X(i-1) mod m
        /// Значения q и r использются, для 
        /// предотвращения переполнения.
        /// </summary>

        private const int a = 16807;
        private const int m = 2147483647;
        private const int q = m / a;
        private const int r = m % a;
        private int seed;
        // Диапазон для seed [1, int.MaxValue - 1]
        public LehmerRng(int seed)
        {
            if (seed <= 0 || seed == int.MaxValue)
                throw new Exception("Bad seed");
            this.seed = seed;
        }
        // Метод возвращает число в диапазоне [0.0, 1.0)
        public double Next()
        {
            //lo - мин значение интервала, hi - макс значение интервала
            int hi = seed / q;
            int lo = seed % q;
            seed = (a * lo) - (r * hi);
            if (seed <= 0)
                seed = seed + m;
            return (seed * 1.0) / m;
        }
    }
}
