using System;
using TalkingClock.Services;

namespace LBG.Client.Shell
{
    public class BootStrapper
    {
        private ITalkingClockService _talkingClockService;

        public void ConfigureContainer()
        {
            _talkingClockService = new TalkingClockService();
        }

        public void StartClient(string[] args)
        {
            if (args.Length == 0)
            {
                var time = DateTime.Now.TimeOfDay;
                var hours = time.Hours.ToString();
                var minutes = time.Minutes.ToString("00");
                var timeString = string.Concat(hours, ":", minutes);
                WriteHumanFriendlyText(timeString);                
            }
            else
            {
                var time = args[0];
                WriteHumanFriendlyText(time);                
            }
        }

        private void WriteHumanFriendlyText(string time)
        {
            Console.WriteLine(_talkingClockService.GetHumanFriendlyText(time));
            Console.ReadKey();
        }
    }
}
