using HelloWorldLibrary.Step00;
using HelloWorldLibrary.Step01;
using HelloWorldLibrary.Step02;
using NFluent;
using System;
using Xunit;

namespace HelloWorldLibrary.Tests
{
    public sealed class HelloWorldServiceTest
    {
        [Fact]
        public void Step01_callWorksInDebug()
        {
            string output = new HelloWorldService00().SayHelloWorld();
        }

        [Fact]
        public void Step02_addAnAssertionToAutoValidate()
        {
            string output = new HelloWorldService01().SayHelloWorld();

            Check.That(output).StartsWith
                ($"Hello World! it's {DateTime.Now:HH:mm}");
        }

        [Fact]
        public void Step02_addThePartOfTheDay()
        {
            string output = new HelloWorldService02(
                new Step02.DateAndTimeRepository())
                // Nice but we don't control now for the moment.
                .SayHelloWorld();

            Check.That(output).IsEqualTo(
                $"Hello World! it's {DateTime.Now:HH:mm}, good evening!");
        }

        // ===========================

        [Fact]
        public void Step05_addThePartOfTheDay_morning()
        {
            DateTime original = new DateTime(2021, 9, 9, 6, 0, 0);

            FakeDateTimeRepo someRepo = new FakeDateTimeRepo();

            someRepo.SetNow(original);

            string output = new HelloWorldService03(someRepo)
                // Nice but we don't control now for the moment.
                .SayHelloWorld();

            Check.That(output).IsEqualTo(
                $"Hello World! it's {original:HH:mm}, good morning!");
        }

        [Fact]
        public void Step05_addThePartOfTheDay_afternoon()
        {
            DateTime original = new DateTime(2021, 9, 9, 15, 0, 0);

            FakeDateTimeRepo someRepo = new FakeDateTimeRepo();

            someRepo.SetNow(original);

            string output = new HelloWorldService03(someRepo)
                // Nice but we don't control now for the moment.
                .SayHelloWorld();

            Check.That(output).IsEqualTo(
                $"Hello World! it's {original:HH:mm}, good afternoon!");
        }

        [Fact]
        public void Step05_addThePartOfTheDay_evening()
        {
            DateTime original = new DateTime(2021, 9, 9, 17, 0, 0);

            FakeDateTimeRepo someRepo = new FakeDateTimeRepo();

            someRepo.SetNow(original);

            string output = new HelloWorldService04(someRepo)
                // Nice but we don't control now for the moment.
                .SayHelloWorld();

            Check.That(output).IsEqualTo(
                $"Hello World! it's {original:HH:mm}, good evening!");
        }

        // ===========================
    }
}
