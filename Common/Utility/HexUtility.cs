using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Utility
{
    public class HexUtility
    {
        /// <summary>
        /// 將Binary的資料轉成Hex
        /// </summary>
        /// <param name="datas"></param>
        /// <returns></returns>
        public string ConvertToHex(byte[] datas)
        {
            var reslut = string.Empty;
            StringBuilder sb = new StringBuilder();

            foreach (byte letter in datas)
            {
                sb.Append(Convert.ToString(letter, 16).PadLeft(2, '0'));
            }
            reslut = sb.ToString();
            return reslut;
        }

        /// <summary>
        /// 將Hex的資料轉成Binary
        /// </summary>
        /// <param name="datas"></param>
        /// <returns></returns>
        public byte[] ConvertToBytes(string datas)
        {
            List<byte> result = new List<byte>();

            using (StringReader sr = new StringReader(datas))
            {
                while (true)
                {
                    char[] c = new char[2];
                    if (sr.Read(c, 0, 2) != 2)
                    {
                        break;
                    }

                    result.Add(Convert.ToByte(Convert.ToByte(c[0].ToString() + c[1].ToString(), 16)));
                }
            }

            return result.ToArray();
        }
    }
}
