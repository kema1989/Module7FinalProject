using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7FinalProject
{
    class TotalSum
    {
        private static double sum = 0;
        public static double GetSum(double price)
        {
            return sum + price;
        }

        public static double Sum()
        {
            return GetSum(0);
        }
    }
}
