using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    public class Calculator
    {
        /// <summary>
        /// Вычисляет Z по заданным x и y.
        /// </summary>
        /// <param_name="x">Первое число</param>
        /// <param_name="y">Второе число</param>
        /// <returns>Результат Z</returns>
        /// <exception_cref="ArgumentException">Если x или y не являются числами</exception>
        public static double CalculateZ(double x, double y)
        {
            if (x < 0)
            {
                return Math.Max(x, y);
            }
            else
            {
                return Math.Min(x, y);
            }
        }
    }
}
