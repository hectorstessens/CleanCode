using Newtonsoft.Json;
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CleanCode.Helpers
{
    //Meaninful Names - Class Names

    public static class HelperManager
    {
        public const string emailRegex = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
       @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9][\-a-z0-9A-Z]{0,22}[a-z0-9A-Z]))$";

        public const string formattedIDNumber = @"[^0-9a-zA-Z]+";

        public static string RemoveSpecialCaracter()
        {
            var text = "abc123_*#@";
            text = Regex.Replace(text, "[^\\w\\._]", "");
            return text;
        }

        public static bool IsEmail(this string str)
=> !string.IsNullOrEmpty(str) && Regex.IsMatch(str, emailRegex);

        public static string FormatIdNumber(this string str)
        {
            if (!string.IsNullOrEmpty(str))
                return Regex.Replace(str, formattedIDNumber, "");

            return str;
        }

        public static string FormatDni(this string str)
        {
            if (!string.IsNullOrEmpty(str))
                return str.Substring(2, 8).TrimStart(new Char[] { '0' });

            return str;
        }

        public static string GetPropValue(this object src, string propName)
        {
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            return myTI.ToTitleCase(src.GetType().GetProperty(propName).GetValue(src, null).ToString().ToLower());
        }

        public static string SerializeObject(this object obj)
=> JsonConvert.SerializeObject(obj);
    }
}
