using System;
using System.Reflection;
using Xunit;

namespace SampleTests
{
    public class ExampleTests
    {
        //Check if user created method exists
        [Fact]
        public void ExampleMethodExists()
        {
            //confirm method exists
            var method = typeof(SampleProject.Program).GetMethod("ExampleMethod", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
            Assert.True(method != null);
        }

        //Check output of user created method
        [Fact]
        public void ExampleMethodReturnsExampleMethod()
        {
            var method = typeof(SampleProject.Program).GetMethod("ExampleMethod", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
            var expected = "ExampleMethod";
            var actual = method.Invoke(this, null);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ExampleMethod2ReturnsInput()
        {
            var input = "Test1";
            var expected = "Test1";
            var actual = SampleProject.Program.ExampleMethod2(input);
            Assert.Equal(expected, actual);
        }
    }
}
