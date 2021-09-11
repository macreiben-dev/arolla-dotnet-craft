using System;

namespace HelloWorldLibrary.Step03
{
    public class DateAndTimeRepository : IDateAndTimeRepository
    {
        public DateTime Now()
        {
            return DateTime.Now;
        }
    }
}
