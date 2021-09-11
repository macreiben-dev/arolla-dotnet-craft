using HelloWorldLibrary.Step00;
using NFluent;
using System;
using Xunit;

namespace HelloWorldLibrary.Tests.Step00
{
    public class HelloWorldService00Test
    {

        [Fact]
        public void Testing00_callWorksInDebug()
        {
            string output = new HelloWorldService00().SayHelloWorld();
        }


        [Fact]
        public void Testing01_addAnAssertionToAutoValidate()
        {
            string output = new HelloWorldService00().SayHelloWorld();

            Check.That(output).StartsWith
                ($"Hello World! it's {DateTime.Now:HH:mm}");
        }


    }
}
