using HelloWorldLibrary.Step01;
using NFluent;
using System;
using Xunit;

namespace HelloWorldLibrary.Tests.Step01
{
    public class HelloWorldService01Test
    {
        // =================================================
        // Previous tests

        [Fact]
        public void Testing00_callWorksInDebug()
        {
            string output = new HelloWorldService01().SayHelloWorld();
        }


        [Fact]
        public void Testing01_addAnAssertionToAutoValidate()
        {
            string output = new HelloWorldService01().SayHelloWorld();

            Check.That(output).StartsWith
                ($"Hello World! it's {DateTime.Now:HH:mm}");
        }

        // =================================================

        [Fact]
        public void Step02_addThePartOfTheDay()
        {
            string output = new HelloWorldService01()
                .SayHelloWorld();

            Check.That(output).IsEqualTo(
                $"Hello World! it's {DateTime.Now:HH:mm}, good evening!");
        }

    }
}
