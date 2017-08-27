using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Utility
{
    public class NumberUtility
    {
        /// <summary>
        /// string 轉 int
        /// </summary>
        /// <typeparam name="int"></typeparam>
        /// <param name="string"></param>
        /// <returns></returns>
        public int ParseToInt(string st)
        {
            int result = 0;
            if (!String.IsNullOrEmpty(st))
            {
                int.TryParse(st, out result);
            }
            return result;
        }

        /// <summary>
        /// string 轉 double
        /// </summary>
        /// <typeparam name="double"></typeparam>
        /// <param name="string"></param>
        /// <returns></returns>
        public double ParseToDouble(string st)
        {
            double result = 0.00;
            if (!String.IsNullOrEmpty(st))
            {
                double.TryParse(st, out result);
            }
            return result;
        }

        /// <summary>
        /// string 轉 decimal
        /// </summary>
        /// <typeparam name="decimal"></typeparam>
        /// <param name="string"></param>
        /// <returns></returns>
        public decimal ParseToDecimal(string st)
        {
            decimal result = 0;
            if (!String.IsNullOrEmpty(st))
            {
                decimal.TryParse(st, out result);
            }
            return result;
        }
    }
}
