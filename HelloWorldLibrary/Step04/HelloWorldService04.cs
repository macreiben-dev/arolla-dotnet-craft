using HelloWorldLibrary.Step05;
using System;

namespace HelloWorldLibrary
{
    public sealed class HelloWorldService04
    {
        private readonly IDateAndTimeRepository dateTimeRepo;

        public HelloWorldService04(IDateAndTimeRepository dateTimeRepo)
        {
            this.dateTimeRepo = dateTimeRepo;
        }

        public string SayHelloWorld()
        {
            DateTime now = dateTimeRepo.Now();

            string partOfTheDay= DeterminePartOfTheDay(now);

            return $"Hello World! it's {now:HH:mm}, good {partOfTheDay}!";
        }

        private string DeterminePartOfTheDay(DateTime now)
        {
            if (IsMorning(now, dateTimeRepo.Middday()))
            {
                return "morning";
            }

            if (IsAfternoon(now, dateTimeRepo.Middday(), dateTimeRepo.Gouter()))
            {
                return "afternoon";
            }

            return "evening";

        }

        private static bool IsMorning(DateTime now, DateTime nowMiddDay)
        {
            return now.CompareTo(nowMiddDay) == -1;
        }

        private static bool IsAfternoon(DateTime now, DateTime nowMiddDay, DateTime nowGouter)
        {
            return now.CompareTo(nowMiddDay) >= 0
                            && now.CompareTo(nowGouter) == -1;
        }
    }
}
