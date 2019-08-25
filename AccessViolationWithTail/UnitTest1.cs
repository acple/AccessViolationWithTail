using System;
using TailCallTestAssembly;
using Xunit;

namespace AccessViolationWithTail
{
    public class UnitTest1
    {
        [Fact]
        public void CharAccessViolationTest()
        {
            var input = 'a';
            Assert.Equal(input.ToString(), Class1.TestFunction(input));
        }

        [Fact]
        public void DateTimeAccessViolationTest()
        {
            var input = DateTime.UtcNow;
            Assert.Equal(input.ToString(), Class1.TestFunction(input));
        }

        [Fact]
        public void DoubleAccessViolationTest()
        {
            var input = 123456789.123456789;
            Assert.Equal(input.ToString(), Class1.TestFunction(input));
        }

        [Fact]
        public void StringAccessViolationTest()
        {
            var input = "stringstring";
            Assert.Equal(input.ToString(), Class1.TestFunction(input));
        }

        [Fact]
        public void intAccessViolationTest()
        {
            var input = int.MaxValue;
            Assert.Equal(input.ToString(), Class1.TestFunction(input));
        }

        [Fact]
        public void ByteAccessViolationTest()
        {
            var input = (byte)0xAA;
            Assert.Equal(input.ToString(), Class1.TestFunction(input));
        }

        [Fact]
        public void ShortAccessViolationTest()
        {
            var input = (short)1234;
            Assert.Equal(input.ToString(), Class1.TestFunction(input));
        }

        [Fact]
        public void LongAccessViolationTest()
        {
            var input = 12345678901234L;
            Assert.Equal(input.ToString(), Class1.TestFunction(input));
        }

        [Fact]
        public void ObjectAccessViolationTest()
        {
            var input = new object();
            Assert.Equal(input.ToString(), Class1.TestFunction(input));
        }
    }
}
