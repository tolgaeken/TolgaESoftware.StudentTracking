using System;
using System.Globalization;

namespace TolgaESoftware.StudentTracking.UI.Win.Functions
{
    public static class ConvertToText
    {
        #region AsText
        private static readonly string[] Numbers = { "", "BİR", "İKİ", "ÜÇ", "DÖRT", "BEŞ", "ALTI", "YEDİ", "SEKİZ", "DOKUZ" };
        private static readonly string[] Tens = { "", "ON", "YİRMİ", "OTUZ", "KIRK", "ELLİ", "ALTMIŞ", "YETMİŞ", "SEKSEN", "DOKSAN" };
        private static readonly string[] ThousandsAndMore = { "", "BİN", "MİLYON", "MİLYAR", "TRİLYON" };

        private static string Thousands(int value)
        {
            return (value >= 100 ? (value >= 200 ? Numbers[value / 100] : "") + "YÜZ" : "") + (value % 100 >= 10 ? Tens[value % 100 / 10] : "") + Numbers[value % 10];
        }

        private static string AsText(long value)
        {
            var text = "";
            var subStr = "" + value;
            var length = subStr.Length;
            var digit = (int)Math.Ceiling(((decimal)length) / 3);
            var maxDigit = length % 3 > 0 ? length % 3 : 3;
            for (var i = digit - 1; i >= 0; i--)
            {
                if (i != digit - 1)
                {
                    var d = int.Parse(subStr.Substring((digit - i - 2) * 3 + maxDigit, 3));
                    text += Thousands(d) + (d > 0 ? Numbers[i] : "");
                }
                else
                {
                    var valueStr = subStr.Substring(0, maxDigit);
                    var valueInt = int.Parse(valueStr);
                    text += (i != 1 || valueInt != 1 ? Thousands(valueInt) : "") + ThousandsAndMore[i];
                }
            }
            if (value == 0)
                text = "SIFIR";
            return text;
        }

        public static string PriceAsText(this decimal value)
        {
            var penny = value - Math.Floor(value);
            return AsText((long)Math.Floor(value)) + " ₺ , " + AsText((long)Math.Floor(penny * 100)) + " Kr.";

        } 
        #endregion

        #region AsTextDate
        private static readonly string[] NumbersAsDate = { "", "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
        private static readonly string[] TensAsDate = { "", "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
        private static readonly string[] ThousandsAndMoreAsDate = { "", "Bin", "Milyon", "Mlyar", "Trilyon" };

        private static string ThousandsAsTextDate(int value)
        {
            return (value >= 100 ? (value >= 200 ? NumbersAsDate[value / 100] : "") + "Yüz" : "") + (value % 100 >= 10 ? TensAsDate[value % 100 / 10] : "") + NumbersAsDate[value % 10];
        }

        private static string AsTextDate(long value)
        {
            var text = "";
            var subStr = "" + value;
            var length = subStr.Length;
            var digit = (int)Math.Ceiling(((decimal)length) / 3);
            var maxDigit = length % 3 > 0 ? length % 3 : 3;
            for (var i = digit - 1; i >= 0; i--)
            {
                if (i != digit - 1)
                {
                    var d = int.Parse(subStr.Substring((digit - i - 2) * 3 + maxDigit, 3));
                    text += ThousandsAsTextDate(d) + (d > 0 ? NumbersAsDate[i] : "");
                }
                else
                {
                    var valueStr = subStr.Substring(0, maxDigit);
                    var valueInt = int.Parse(valueStr);
                    text += (i != 1 || valueInt != 1 ? ThousandsAsTextDate(valueInt) : "") + ThousandsAndMoreAsDate[i];
                }
            }
            if (value == 0)
                text = "Sıfır";
            return text;
        }

        public static string PaymentTermAsTextDate(this DateTime date)
        {
            var dateAsDate = AsTextDate(date.Day);
            var monthAsDate = date.ToString("MMMMM", new CultureInfo("tr-TR"));
            var yearAsDate = AsTextDate(date.Year);
            return dateAsDate + " " + monthAsDate + " " + yearAsDate;
        } 
        #endregion
    }
}