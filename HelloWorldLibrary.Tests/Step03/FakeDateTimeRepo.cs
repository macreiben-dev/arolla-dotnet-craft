using HelloWorldLibrary.Step03;
using System;

namespace HelloWorldLibrary.Tests.Step03
{
    public class FakeDateTimeRepo : IDateAndTimeRepository
    {
        private DateTime _now;

        public void SetNow(DateTime dateTime)
        {
            _now = dateTime;
        }

        public DateTime Now()
        {
            return _now;
        }
    }
}
