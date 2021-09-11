using System;

namespace HelloWorldLibrary.Step01
{
    public sealed class HelloWorldService01
    {
        public string SayHelloWorld()
        {
            DateTime now = DateTime.Now;

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
