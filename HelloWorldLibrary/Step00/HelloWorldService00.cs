using System;

namespace HelloWorldLibrary.Step00
{
    public sealed class HelloWorldService00
    {
        public string SayHelloWorld()
        {
            return $"Hello World! it's {DateTime.Now:HH:mm}";
        }
    }

}
