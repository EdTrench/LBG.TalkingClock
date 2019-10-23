using TalkingClock.Extensions;

namespace TalkingClock.Services
{
    public class TalkingClockService : ITalkingClockService
    {
        public string GetHumanFriendlyText(string input)
        {
            // todo: validate input parameter
            
            var minutes = input.ConvertToMinutes();
            var hour = input.ConvertToTwelveHour();

            if (minutes.IsOnTheHour())
            {
                return hour.OnTheHourHumanFriendlyText();
            }

            if (minutes.IsPastTheHour())
            {
                return hour.PastTheHourHumanFriendlyText(minutes);
            }

            if (minutes.IsHalfPastTheHour())
            {
                return hour.HalfPastTheHourHumanFriendlyText();
            }

            if (minutes.IsToTheHour())
            {
                return hour.ToTheHourHumanFriendlyText(minutes);
            }

            return "Log Error - uknown input";
        }
    }
}
