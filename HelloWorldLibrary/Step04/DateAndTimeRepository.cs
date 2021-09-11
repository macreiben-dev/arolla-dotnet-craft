using System;

namespace HelloWorldLibrary.Step05
{
    public class DateAndTimeRepository : IDateAndTimeRepository
    {
        public DateTime Now()
        {
            return DateTime.Now;
        }
    }
}
