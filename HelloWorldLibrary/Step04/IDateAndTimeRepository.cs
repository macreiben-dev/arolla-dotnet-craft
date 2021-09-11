using System;

namespace HelloWorldLibrary.Step05
{
    public interface IDateAndTimeRepository
    {
        DateTime Now();

        DateTime Middday();

        DateTime Gouter();
    }
}