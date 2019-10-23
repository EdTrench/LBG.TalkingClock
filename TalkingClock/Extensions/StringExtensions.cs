using System;
using System.Linq;

namespace TalkingClock.Extensions
{
    public static class StringExtensions
    {
        public static string FirstCharToUpper(this string input)
        {
            return string.Concat(input.First().ToString().ToUpper(), input.Substring(1));
        }

        public static int ConvertToTwelveHour(this string input)
        {
            var colonPosition = input.IndexOf(":", StringComparison.Ordinal);
            var hour = Convert.ToInt32(input.Substring(0, colonPosition));
            return hour == 0 || hour == 12 ? 12 : hour % 12;
        }

        public static int ConvertToMinutes(this string input)
        {
            var colonPosition = input.IndexOf(":", StringComparison.Ordinal);
            return Convert.ToInt32(input.Substring(colonPosition + 1));
        }
    }
}
