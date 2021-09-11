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

            DateTime nowMiddDay = new DateTime(
                now.Year, now.Month, now.Day, 12, 0, 0);

            DateTime nowGouter = new DateTime(
                now.Year, now.Month, now.Day, 16, 30, 0);

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
