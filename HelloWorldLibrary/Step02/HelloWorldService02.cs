using System;

namespace HelloWorldLibrary.Step02
{
    public sealed class HelloWorldService02
    {
        private readonly DateAndTimeRepository dateTimeRepo;

        public HelloWorldService02(DateAndTimeRepository dateTimeRepo)
        {
            this.dateTimeRepo = dateTimeRepo;
        }

        public string SayHelloWorld()
        {
            DateTime now = dateTimeRepo.Now();

            DateTime nowMiddDay = new DateTime(now.Year, now.Month, now.Day, 12, 0, 0);
            DateTime nowGouter = new DateTime(now.Year, now.Month, now.Day, 16, 30, 0);

            string partOfTheDay;

            if (now.CompareTo(nowMiddDay) == -1)
            {
                partOfTheDay = "morning";
            }
            else if (
                now.CompareTo(nowMiddDay) >= 0
                && now.CompareTo(nowGouter) == -1)
            {
                partOfTheDay = "afternoon";
            }
            else
            {
                partOfTheDay = "evening";
            }

            return $"Hello World! it's {now:HH:mm}, good {partOfTheDay}!";
        }
    }
}
