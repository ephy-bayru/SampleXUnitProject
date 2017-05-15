using System;

namespace SampleProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string ExampleMethod()
        {
            return "ExampleMethod";
        }

        public static string ExampleMethod2 (string input)
        {
            return input + "FAIL";
        }
    }
}