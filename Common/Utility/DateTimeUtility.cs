using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Common.Utility
{
    public class DateTimeUtility
    {
        #region "1. 短的時間格式 YYYYMMDD"

        /// <summary>
        /// 短的時間格式 YYYYMMDD
        /// </summary>
        /// <returns>格式化後的時間</returns>
        public string GetNowShortDateString()
        {
            return GetNowShortDateString(DateTime.Now);
        }

        /// <summary>
        /// 短的時間格式 YYYYMMDD
        /// </summary>
        /// <returns>格式化後的時間</returns>
        public string GetNowShortDateString(DateTime date)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(date.Year.ToString("0000"));
            sb.Append(date.Month.ToString("00"));
            sb.Append(date.Day.ToString("00"));

            return sb.ToString();
        }

        #endregion "1. 短的時間格式 YYYYMMDD"

        #region "2. 長的時間格式 yyyyMMddHHmmSSsss"

        /// <summary>
        /// 長的時間格式
        /// yyyyMMddHHmmSSsss
        /// </summary>
        /// <returns>格式化後的時間</returns>
        public string GetNowLongDateString()
        {
            return GetNowLongDateString(DateTime.Now);
        }

        /// <summary>
        /// 長的時間格式
        /// yyyyMMddHHmmSSsss
        /// </summary>
        /// <returns>格式化後的時間</returns>
        public string GetNowLongDateString(DateTime dateTime)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(dateTime.Year.ToString("0000"));
            sb.Append(dateTime.Month.ToString("00"));
            sb.Append(dateTime.Day.ToString("00"));

            sb.Append(dateTime.Hour.ToString("00"));
            sb.Append(dateTime.Minute.ToString("00"));
            sb.Append(dateTime.Second.ToString("00"));
            sb.Append(dateTime.Millisecond.ToString("000"));

            return sb.ToString();
        }

        #endregion "2. 長的時間格式 yyyyMMddHHmmSSsss"

        #region "3. 長的時間格式 yyyy-MM-dd HH:mm:SS sss"

        /// <summary>
        /// 長的時間格式 yyyy-MM-dd HH:mm:SS sss
        /// </summary>
        /// <returns>格式化後的時間</returns>
        public string getNowLongDateString2()
        {
            return GetNowLongDateString2(DateTime.Now);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public string GetNowLongDateString2(DateTime time)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(time.Year.ToString("0000"));
            sb.Append("-");
            sb.Append(time.Month.ToString("00"));
            sb.Append("-");
            sb.Append(time.Day.ToString("00"));
            sb.Append(" ");
            sb.Append(time.Hour.ToString("00"));
            sb.Append(":");
            sb.Append(time.Minute.ToString("00"));
            sb.Append(":");
            sb.Append(time.Second.ToString("00"));
            sb.Append(" ");
            sb.Append(time.Millisecond.ToString("000"));

            return sb.ToString();
        }

        #endregion "3. 長的時間格式 yyyy-MM-dd HH:mm:SS sss"

        #region "4. 短的時間格式 hh:mm:ss"

        /// <summary>
        /// 短的時間格式 hh:mm:ss
        /// </summary>
        /// <returns>格式化後的時間</returns>
        public string GetNowShortTimeString()
        {
            return GetNowShortTimeString(DateTime.Now);
        }

        /// <summary>
        /// 短的時間格式 hh:mm:ss
        /// </summary>
        /// <returns>格式化後的時間</returns>
        public string GetNowShortTimeString(DateTime dateTime)
        {
            return dateTime.Hour.ToString("00") + ":" +
                   dateTime.Minute.ToString("00") + ":" +
                   dateTime.Second.ToString("00");
        }

        #endregion "4. 短的時間格式 hh:mm:ss"

        #region "5. 短的時間格式，hhmmss"

        /// <summary>
        /// 短的時間格式，[hhmmss]
        /// </summary>
        /// <returns>格式化後的時間</returns>
        public string GetNowShortTimeStringHHMMSS()
        {
            return GetNowShortTimeStringHHMMSS(DateTime.Now);
        }

        /// 短的時間格式，[hhmmss]
        /// </summary>
        /// <returns>格式化後的時間</returns>
        public string GetNowShortTimeStringHHMMSS(DateTime dateTime)
        {
            return DateTime.Now.Hour.ToString("00") +
                   DateTime.Now.Minute.ToString("00") +
                   DateTime.Now.Second.ToString("00");
        }

        #endregion "5. 短的時間格式，hhmmss"

        #region "6. 取得英文的月份"

        /// <summary>
        /// 取得英文的月份
        /// </summary>
        /// <returns>英文的月份</returns>
        public string GetEnglishMonth()
        {
            string result = string.Empty;

            if (System.DateTime.Now.Month == 1)
            {
                result = "Jan";
            }
            else if (System.DateTime.Now.Month == 2)
            {
                result = "Feb";
            }
            else if (System.DateTime.Now.Month == 3)
            {
                result = "Mar";
            }
            else if (System.DateTime.Now.Month == 4)
            {
                result = "Apr";
            }
            else if (System.DateTime.Now.Month == 5)
            {
                result = "May";
            }
            else if (System.DateTime.Now.Month == 6)
            {
                result = "Jun";
            }
            else if (System.DateTime.Now.Month == 7)
            {
                result = "Jul";
            }
            else if (System.DateTime.Now.Month == 8)
            {
                result = "Aug";
            }
            else if (System.DateTime.Now.Month == 9)
            {
                result = "Sep";
            }
            else if (System.DateTime.Now.Month == 10)
            {
                result = "Oct";
            }
            else if (System.DateTime.Now.Month == 11)
            {
                result = "Nov";
            }
            else if (System.DateTime.Now.Month == 12)
            {
                result = "Dec";
            }

            return result;
        }

        /// <summary>
        /// 取得英文的月份
        /// </summary>
        /// <returns>英文的月份</returns>
        public string GetEnglishMonth(int month)
        {
            string result = string.Empty;

            if (month == 1)
            {
                result = "Jan";
            }
            else if (month == 2)
            {
                result = "Feb";
            }
            else if (month == 3)
            {
                result = "Mar";
            }
            else if (month == 4)
            {
                result = "Apr";
            }
            else if (month == 5)
            {
                result = "May";
            }
            else if (month == 6)
            {
                result = "Jun";
            }
            else if (month == 7)
            {
                result = "Jul";
            }
            else if (month == 8)
            {
                result = "Aug";
            }
            else if (month == 9)
            {
                result = "Sep";
            }
            else if (month == 10)
            {
                result = "Oct";
            }
            else if (month == 11)
            {
                result = "Nov";
            }
            else if (month == 12)
            {
                result = "Dec";
            }

            return result;
        }

        #endregion "6. 取得英文的月份"

        #region "7. 計算日期的差距"
        /// <summary>
        ///
        /// </summary>
        /// <param name="dStart"></param>
        /// <param name="dEnd"></param>
        /// <param name="unit"></param>
        /// <returns></returns>
        public int DateDiff(DateTime dStart, DateTime dEnd, string unit)
        {
            TimeSpan tsCount = dEnd - dStart;

            switch (unit)
            {
                case "day":
                    return (int)tsCount.TotalDays;

                case "hour":
                    return (int)tsCount.TotalHours;

                case "minute":
                    return (int)tsCount.TotalMinutes;

                case "second":
                    return (int)tsCount.TotalSeconds;

                case "millisecond":
                    return (int)tsCount.TotalMilliseconds;
            }

            return 0;
        }

        #endregion "7. 計算日期的差距"

        #region "8. 日期的轉換"

        /// <summary>
        /// 將字串轉成日期
        /// </summary>
        /// <param name="inputDate"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public DateTime? ConvertToDateTime(string inputDate, string format)
        {
            DateTime? result = null;
            try
            {
                IFormatProvider dFormat = new CultureInfo(String.Empty, false);
                result = DateTime.ParseExact(inputDate, format, dFormat);
            }
            catch (Exception)
            {
                throw;
            }

            return result;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="inputDate"></param>
        /// <returns></returns>
        public DateTime? ConvertToDateTimeSQL(string inputDate)
        {
            DateTime? result = null;
            try
            {
                // "yyyy-mm-dd hh:MM:ss"
                if (string.IsNullOrEmpty(inputDate))
                {
                    return null;
                }

                string[] datas = inputDate.Split(new char[] { ' ' });
                string[] ary1 = datas[0].Split(new char[] { '-' });
                string[] ary2 = datas[1].Split(new char[] { ':' });

                result = new DateTime(int.Parse(ary1[0]), int.Parse(ary1[1]), int.Parse(ary1[2]), int.Parse(ary2[0]), int.Parse(ary2[1]), int.Parse(ary2[2]));
            }
            catch (Exception)
            {
                throw;
            }

            return result;
        }

        #endregion "8. 日期的轉換"

        #region "格林威治與當地時區轉換"

        private readonly DateTime GTM = new DateTime(1970, 1, 1);//宣告一個GTM時間出來

        /// <summary>
        /// 當地時間轉UTC時戳
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public double DateTimeToTimeStamp(DateTime dateTime)
        {
            var utc = dateTime.ToUniversalTime();
            return utc.Subtract(GTM).TotalSeconds;
        }

        /// <summary>
        /// UTC時戳轉當地時間datetime
        /// </summary>
        /// <param name="timeStamp"></param>
        /// <returns></returns>
        public DateTime TimeStampToLongTime(double timeStamp)
        {
            DateTime utc = GTM.AddSeconds(timeStamp);
            return utc.ToLocalTime();
        }

        /// <summary>
        /// UTC時間轉當地時間datetime
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public DateTime GetLocalTime(DateTime dateTime)
        {
            return TimeStampToLongTime(DateTimeToTimeStamp(dateTime));
        }

        #endregion "格林威治與當地時區轉換"

        #region "Unformat"

        /// <summary>
        ///
        /// </summary>
        /// <param name="EndDate"></param>
        /// <returns></returns>
        public string UnformatDate(string endDate)
        {
            if (!string.IsNullOrEmpty(endDate))
            {
                return endDate.Replace("/", "");
            }

            return string.Empty;
        }

        #endregion "Unformat"

        #region "取得目前系統時間(UTC)"

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public string GetDateTimeNowUTC()
        {
            return GetUTCDateTimeNow().ToString("yyyy-MM-dd HH:mm:ss.fffffff");
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public DateTime GetUTCDateTimeNow()
        {
            return DateTime.Now.ToUniversalTime();
        }

        #endregion "取得目前系統時間(UTC)"

        #region "取得目前系統時間(Local)"

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public string GetDateTimeNowLocal()
        {
            return GetDateTimeNow().ToString();
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public DateTime GetDateTimeNow()
        {
            return DateTime.Now;
        }

        #endregion "取得目前系統時間(Local)"

        #region "查詢用起迄日轉換"

        /// <summary>
        /// 轉換查詢用起日
        /// </summary>
        /// <param name="beginDate"></param>
        /// <returns></returns>
        public DateTime GetBeginDateForSelectDB(string beginDate)
        {
            //string result = beginDate;
            DateTime dt = new DateTime();
            if (!string.IsNullOrEmpty(beginDate))
            {
                var sDate = UtilityFactory.Instance().StringUtility.IIF(beginDate).Trim().Replace("/", "").Replace("-", "").Replace(" ", "").Replace(":", "").Replace(".", "");
                if (sDate.Length == 4)
                {
                    sDate += "0101000000000";//MMddhhmmssfff
                }
                else if (sDate.Length == 6)
                {
                    sDate += "01000000000";//ddhhmmssfff
                }
                else if (sDate.Length == 8)
                {
                    sDate += "000000000";//hhmmssfff
                }
                else if (sDate.Length == 12)
                {
                    sDate += "00000";//ssfff
                }
                else if (sDate.Length == 14)
                {
                    sDate += "000";//fff
                }
                if (DateTime.TryParseExact(sDate
                    , "yyyyMMddHHmmssfff"
                    , CultureInfo.InvariantCulture
                    , DateTimeStyles.None
                    , out dt))
                {
                    dt = dt.ToUniversalTime();
                }
            }
            return dt;
        }

        /// <summary>
        /// 轉換查詢用迄日
        /// </summary>
        /// <param name="beginDate"></param>
        /// <returns></returns>
        public DateTime GetEndDateForSelectDB(string endDate)
        {
            DateTime dt = new DateTime();
            if (!string.IsNullOrEmpty(endDate))
            {
                // ToDo 以目前的處理方式會有問題，待修改 add by alex
                var sDate = UtilityFactory.Instance().StringUtility.IIF(endDate).Trim().Replace("/", "").Replace("-", "").Replace(" ", "").Replace(":", "").Replace(".", "");
                if (sDate.Length == 4)
                {
                    sDate += "1231235959999";//MMddhhmmssfff
                }
                else if (sDate.Length == 6)
                {
                    sDate += "31235959999";//ddhhmmssfff
                }
                else if (sDate.Length == 8)
                {
                    sDate += "235959999";//hhmmssffff
                }
                else if (sDate.Length == 12)
                {
                    sDate += "59999";//ssffff
                }
                else if (sDate.Length == 14)
                {
                    sDate += "999";//ffff
                }
                if (DateTime.TryParseExact(sDate
                    , "yyyyMMddHHmmssfff"
                    , CultureInfo.InvariantCulture
                    , DateTimeStyles.None
                    , out dt))
                {
                    dt = dt.ToUniversalTime();
                }
            }

            return dt;
        }

        #endregion "查詢用起迄日轉換"

        #region "英文星期轉中文星期"

        public string ConverWeekToZhTW(string date)
        {
            switch (date)
            {
                case "Monday": return "(一)";
                case "Tuesday": return "(二)";
                case "Wednesday": return "(三)";
                case "Thursday": return "(四)";
                case "Friday": return "(五)";
                case "Saturday": return "(六)";
                case "Sunday": return "(日)";
                default: return "";
            }
        }

        #endregion "英文星期轉中文星期"

        #region "相對日處理"

        /// <summary>
        /// 取得指定比較日期的週期(月)相對日
        /// </summary>
        /// <param name="referenceDate">基準日</param>
        /// <param name="compareDate">比較日</param>
        /// <param name="cycleMonth">週期(月份)</param>
        /// <returns></returns>
        public string GetRelativeDateByCycle(string referenceDate, string compareDate, string cycleMonth)
        {
            string relativeDate = "";
            try
            {
                if (string.IsNullOrEmpty(referenceDate) || string.IsNullOrEmpty(compareDate))
                {
                    return string.Empty;
                }
                else
                {
                    // Note: 先設定相對日為基準日
                    DateTime relativeDT = new DateTime();

                    // Note: 比較日
                    DateTime compareDT = new DateTime();

                    if (DateTime.TryParse(referenceDate, out relativeDT) && DateTime.TryParse(compareDate, out compareDT))
                    {
                        bool isComplete = false;

                        // Note: 開始依週期計算相對日，重複計算直到大於等於比較日停止
                        while (!isComplete)
                        {
                            relativeDT = relativeDT.AddMonths(UtilityFactory.Instance().NumberUtility.ParseToInt(cycleMonth));

                            // 計算出來的[相對日]>[比較日]時，因[比較日]為週期的起日，所以迄日即為[相對日]
                            if (relativeDT.CompareTo(compareDT) > 0)
                            {
                                isComplete = true;
                            }
                            // 計算出來的[相對日]=[比較日]時，因[比較日]為週期的起日，則[相對日]須再+1個月
                            else if (relativeDT.CompareTo(compareDT) == 0)
                            {
                                relativeDT = relativeDT.AddMonths(1);
                                isComplete = true;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        if (relativeDT != null && relativeDT != DateTime.MinValue && relativeDT != DateTime.MaxValue)
                        {
                            relativeDate = relativeDT.ToString("yyyy/MM/dd");
                        }
                    }
                }
            }
            catch (Exception)
            {
                relativeDate = "";
                throw;
            }
            return relativeDate;
        }

        #endregion "相對日處理"
    }
}
