using HelloWorldLibrary.Step03;
using NFluent;
using System;
using Xunit;

namespace HelloWorldLibrary.Tests.Step03
{
    public class HelloWorldService03Test
    {
        // =================================================
        // Previous tests

        [Fact]
        public void Step03_addThePartOfTheDay()
        {
            string output = new HelloWorldService03(
                new DateAndTimeRepository())
                .SayHelloWorld();

            Check.That(output).IsEqualTo(
                $"Hello World! it's {DateTime.Now:HH:mm}, good evening!");
        }

        // =================================================

        /*
         * Introduce the abstraction to change the dateAndtimeRepo to control the "now".
         * */

        [Fact]
        public void Step03_addThePartOfTheDay_morning()
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

        /*
         * Gives us the ability to test each code branch.
         * */

        [Fact]
        public void Step03_addThePartOfTheDay_afternoon()
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
        public void Step03_addThePartOfTheDay_evening()
        {
            DateTime original = new DateTime(2021, 9, 9, 17, 0, 0);

            FakeDateTimeRepo someRepo = new FakeDateTimeRepo();

            someRepo.SetNow(original);

            string output = new HelloWorldService03(someRepo)
                // Nice but we don't control now for the moment.
                .SayHelloWorld();

            Check.That(output).IsEqualTo(
                $"Hello World! it's {original:HH:mm}, good evening!");
        }

        /*
         * That's nice, but could we do better ?
         * */
    }
}
