using Humanizer;

namespace TalkingClock.Extensions
{
    public static class IntegerExtensions
    {
        public static string OnTheHourHumanFriendlyText(this int hour)
        {
            return string.Concat(hour.ToWords(), " o\'clock").FirstCharToUpper();
        }

        public static string PastTheHourHumanFriendlyText(this int hour, int minutes)
        {
            return string.Concat(minutes.ToWords().Replace("-", " "), " past ", hour.ToWords()).FirstCharToUpper();
        }

        public static string HalfPastTheHourHumanFriendlyText(this int hour)
        {
            return string.Concat("Half past ", hour.ToWords()).FirstCharToUpper();
        }

        public static string ToTheHourHumanFriendlyText(this int hour, int minutes)
        {
            return string.Concat((60 - minutes).ToWords().Replace("-", " "), " to ", (hour + 1).ToWords()).FirstCharToUpper();
        }

        public static bool IsOnTheHour(this int minutes)
        {
            return minutes == 0;
        }

        public static bool IsHalfPastTheHour(this int minutes)
        {
            return minutes == 30;
        }

        public static bool IsPastTheHour(this int minutes)
        {
            return minutes >= 1 && minutes <= 29;
        }

        public static bool IsToTheHour(this int minutes)
        {
            return minutes >= 31 && minutes <= 59;
        }
    }
}
