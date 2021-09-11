using HelloWorldLibrary.Step02;
using NFluent;
using System;
using Xunit;

namespace HelloWorldLibrary.Tests.Step02
{
    public class HelloWorldService03Test
    { 
        

        [Fact]
        public void Step02_addThePartOfTheDay()
        {
            string output = new HelloWorldService02(
                new DateAndTimeRepository())
                .SayHelloWorld();

            Check.That(output).IsEqualTo(
                $"Hello World! it's {DateTime.Now:HH:mm}, good evening!");
        }

    }
}
