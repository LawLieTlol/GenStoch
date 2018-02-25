using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenStoch
{
    class LaggedFibRng
    {
        /// <summary>
        /// Пояснение работы алгоритма
        /// X(i) = X(i-7) + X(i-10) mod m
        /// Значения k и j можно изменять.
        /// Отлично подходят — (24,55), (38,89), (37,100), (30,127), (83,258), (107,378).
        /// </summary>
        private const int k = 10; // Largest magnitude"-index"
        private const int j = 7; // Other "-index"
        private const int m = Int32.MaxValue;  // 2^31 - 1 = maxint
        private List<int> vals = null;
        private int seed;

        public LaggedFibRng(int seed)
        {
            //Первые k+1 значения последовательности
            vals = new List<int>();
            for (int i = 0; i < k + 1; ++i)
                vals.Add(seed);
            // Наименьшее из начальных значений k обязательно должно быть нечетным (любым).
            if (seed % 2 == 0)
                vals[0] = 11;
            // Уничтожаем некоторые значения
            for (int ct = 0; ct < 1000; ++ct)
            {
                double dummy = this.Next();
            }
        }  

        public double Next()
        {
            // (a + b) mod n = [(a mod n) + (b mod n)] mod n
            int left = vals[0] % m;    // [x-big]
            int right = vals[k - j] % m; // [x-other]
            long sum = (long)left + (long)right;  // Предотвращаем переполнение
            seed = (int)(sum % m);  // Поскольку m - это int, результат имеет диапазон int
            vals.Insert(k + 1, seed);  // Добавляем новое значение в конец
            vals.RemoveAt(0);  // Удаляем теперь нерелевантное значение [0]
            return (1.0 * seed) / m;
        }
    }
}
