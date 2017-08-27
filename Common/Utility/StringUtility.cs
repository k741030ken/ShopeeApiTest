using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Utility
{
    public class StringUtility
    {
        /// <summary>
        /// 取得去掉前後空白的字串
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string IIF(string text)
        {
            return string.IsNullOrEmpty(text) ? string.Empty : text.Trim();
        }

        /// <summary>
        /// 取得非NULL的字串
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string IIF2(string text)
        {
            return string.IsNullOrEmpty(text) ? string.Empty : text;
        }

        /// <summary>
        /// 取得物件字串
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string IIF(object input)
        {
            if (input != null)
            {
                return IIF(input.ToString());
            }
            return string.Empty;
        }

        /// <summary>
        /// 結合Url
        /// </summary>
        /// <param name="path1"></param>
        /// <param name="path2"></param>
        /// <returns></returns>
        public string UrlCombine(string path1, string path2)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(path1);

            if (!path1.EndsWith("/"))
            {
                sb.Append("/");
            }

            sb.Append(path2);

            return sb.ToString();
        }

        /// <summary>
        /// 取得字串真正的長度
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        public int GetStringRealLength(string inputData)
        {
            int result = 0;

            if (!string.IsNullOrEmpty(inputData))
            {
                for (int i = 0; i < inputData.Length; i++)
                {
                    string cut = inputData.Substring(i, 1);
                    var data = System.Text.Encoding.Unicode.GetBytes(cut);

                    if (data.Length == 1)
                    {
                        result++;
                    }
                    else if (data.Length == 2)
                    {
                        if (data[1] == 0x00)
                        {
                            result++;
                        }
                        else
                        {
                            result += 2;
                        }
                    }
                    else
                    {
                        result += 2;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// 是否為字母字元或中文字
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool IsAlphaOnly(string input)
        {
            char[] chrArray = input.ToCharArray();

            foreach (char c in chrArray)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
                else if (c >= 0x3000)
                {
                    // 中文
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 是否為字母字元、十進位數字或中文字
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool IsAlphaOrDigit(string input)
        {
            char[] chrArray = input.ToCharArray();

            foreach (char c in chrArray)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
                else if (c >= 0x3000)
                {
                    // 中文
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 是否為數字
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool IsDigit(string input)
        {
            char[] chrArray = input.ToCharArray();

            foreach (char c in chrArray)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 將輸入的字串，截成最多固定長度的字串
        /// </summary>
        /// <param name="input"></param>
        /// <param name="everyMaxLength"></param>
        /// <returns></returns>
        public List<string> SplitFixLength(string input, int everyMaxLength)
        {
            List<string> resultList = new List<string>();
            StringBuilder sb = new StringBuilder();

            if (!string.IsNullOrEmpty(input))
            {
                int result = 0;
                int start = 0;

                for (int i = start; i < input.Length; i++)
                {
                    string cut = input.Substring(i, 1);
                    var data = System.Text.Encoding.Unicode.GetBytes(cut);

                    if (data.Length >= 2)
                    {
                        // 中文
                        if (data[1] == 0x00)
                        {
                            if ((result + 1) > everyMaxLength)
                            {
                                resultList.Add(sb.ToString());
                                sb = new StringBuilder();
                            }
                            else
                            {
                                sb.Append(input[i]);
                                result++;
                            }
                        }
                        else
                        {
                            if ((result + 2) > everyMaxLength)
                            {
                                resultList.Add(sb.ToString());
                                sb = new StringBuilder();
                            }
                            else
                            {
                                sb.Append(input[i]);
                                result += 2;
                            }
                        }
                    }
                    else
                    {
                        // 非中文
                        if ((result + 1) > everyMaxLength)
                        {
                            resultList.Add(sb.ToString());
                            sb = new StringBuilder();
                        }
                        else
                        {
                            sb.Append(input[i]);
                            result++;
                        }
                    }
                }
            }

            return resultList;
        }

        /// <summary>
        /// 取得截取後的字串
        /// </summary>
        /// <param name="input">待截取的字串</param>
        /// <param name="startIndex">開始的Index</param>
        /// <param name="length">要取的長度</param>
        /// <returns></returns>
        public string SubStr(string input, int startIndex, int length)
        {
            StringBuilder sb = new StringBuilder();

            if (!string.IsNullOrEmpty(input))
            {
                int result = 0;
                int start = 0;

                // 先求出目前要從那裏開始截
                for (int i = 0; i < input.Length; i++)
                {
                    string cut = input.Substring(i, 1);
                    var data = System.Text.Encoding.Unicode.GetBytes(cut);

                    if (data.Length == 1)
                    {
                        result++;
                    }
                    else if (data.Length == 2)
                    {
                        if (data[1] == 0x00)
                        {
                            result++;
                        }
                        else
                        {
                            result += 2;
                        }
                    }
                    else
                    {
                        result += 2;
                    }

                    if (startIndex == 0)
                    {
                        continue;
                    }

                    if (result >= startIndex)
                    {
                        if (i + 1 <= input.Length)
                        {
                            start = i + 1;
                        }
                        else
                        {
                            return string.Empty;
                        }
                        break;
                    }
                }

                result = 0;

                for (int i = start; i < input.Length; i++)
                {
                    string cut = input.Substring(i, 1);
                    var data = System.Text.Encoding.Unicode.GetBytes(cut);

                    if (data.Length >= 2)
                    {
                        // 中文
                        if (data[1] == 0x00)
                        {
                            if ((result + 1) > length)
                            {
                                break;
                            }
                            else
                            {
                                sb.Append(input[i]);
                                result++;
                            }
                        }
                        else
                        {
                            if ((result + 2) > length)
                            {
                                break;
                            }
                            else
                            {
                                sb.Append(input[i]);
                                result += 2;
                            }
                        }
                    }
                    else
                    {
                        // 非中文
                        if ((result + 1) > length)
                        {
                            break;
                        }
                        else
                        {
                            sb.Append(input[i]);
                            result++;
                        }
                    }
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// 將輸入字串，轉成全型字串
        /// </summary>
        /// <param name="input">輸入字串</param>
        /// <returns>全型字串</returns>
        public string ToWideString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            string asciiTable = "!\"#$%&\'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~";
            string wideTable = "！”＃＄％＆’（）＊＋，－．／０１２３４５６７８９：；＜＝＞？＠ＡＢＣＤＥＦＧＨＩＪＫＬＭＮＯＰＱＲＳＴＵＶＷＸＹＺ〔\\〕︿＿‘ａｂｃｄｅｆｇｈｉｊｋｌｍｎｏｐｑｒｓｔｕｖｗｘｙｚ｛｜｝～";

            try
            {
                char[] aryInput = input.ToCharArray();
                char[] aryWide = wideTable.ToCharArray();

                for (int i = 0; i < aryInput.Length; i++)
                {
                    int index = asciiTable.IndexOf(aryInput[i]);
                    if (index > 0)
                    {
                        aryInput[i] = aryWide[index];
                    }
                }

                return new string(aryInput);
            }
            catch (Exception)
            {
                throw;
            }

            //return input;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string Compress(string text)
        {
            // 空值不處理
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            byte[] buffer = Encoding.UTF8.GetBytes(text);

            MemoryStream ms = new MemoryStream();
            using (GZipStream zip = new GZipStream(ms, CompressionMode.Compress, true))
            {
                zip.Write(buffer, 0, buffer.Length);
            }

            ms.Position = 0;
            MemoryStream outStream = new MemoryStream();

            byte[] compressed = new byte[ms.Length];
            ms.Read(compressed, 0, compressed.Length);

            byte[] gzBuffer = new byte[compressed.Length + 4];
            System.Buffer.BlockCopy(compressed, 0, gzBuffer, 4, compressed.Length);
            System.Buffer.BlockCopy(BitConverter.GetBytes(buffer.Length), 0, gzBuffer, 0, 4);
            return UtilityFactory.Instance().HexUtility.ConvertToHex(gzBuffer);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="compressedText"></param>
        /// <returns></returns>
        public string Decompress(string compressedText)
        {
            // 空值不處理
            if (string.IsNullOrEmpty(compressedText))
            {
                return string.Empty;
            }

            byte[] gzBuffer = UtilityFactory.Instance().HexUtility.ConvertToBytes(compressedText);
            using (MemoryStream ms = new MemoryStream())
            {
                int msgLength = BitConverter.ToInt32(gzBuffer, 0);
                ms.Write(gzBuffer, 4, gzBuffer.Length - 4);

                byte[] buffer = new byte[msgLength];

                ms.Position = 0;
                using (GZipStream zip = new GZipStream(ms, CompressionMode.Decompress))
                {
                    zip.Read(buffer, 0, buffer.Length);
                }

                return Encoding.UTF8.GetString(buffer);
            }
        }
    }
}
