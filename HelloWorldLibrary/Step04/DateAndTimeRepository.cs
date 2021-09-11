using System;

namespace HelloWorldLibrary.Step05
{
    public class DateAndTimeRepository : IDateAndTimeRepository
    {
        public DateTime Now()
        {
            return DateTime.Now;
        }

        public DateTime Middday()
        {
            var now = Now();

            return new DateTime(
                now.Year, now.Month, now.Day, 12, 0, 0);
        }

        public DateTime Gouter()
        {
            var now = Now();

            return new DateTime(
                now.Year, now.Month, now.Day, 16, 30, 0);
        }
    }
}
