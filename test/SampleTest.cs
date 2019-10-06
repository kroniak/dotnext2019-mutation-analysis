using System;
using library;
using Xunit;

namespace test
{
    public class SampleTest
    {
        [Theory]
        [InlineData(false, false)]
        // [InlineData(true, false)]
        // [InlineData(false, true)]
        public void Method_PositiveData_Return0(bool a, bool b)
        {
            // Act
            var result = SampleClass.Method(a, b);

            // Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData(-2)]
        [InlineData(-1)]
        public void LibraryMethod_NegativeData_ThrowException(int val)
        {
            // Act
            var ex = Assert.Throws<Exception>(() => SampleClass.LibraryMethod(val));

            // Assert
            Assert.Equal("Something happened", ex.Message);
            Assert.Equal("USER_DB is not path pattern user_adminXXXX\nParameter name: user-name",
                ex.InnerException.Message);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        public void LibraryMethod_PositiveData_ReturnCorrectString(int val)
        {
            // Act
            var result = SampleClass.LibraryMethod(val);

            // Assert
            Assert.Equal("Successfully", result);
        }

        [Fact]
        public void ForMethod_CorrectCheck()
        {
            // Act
            var i = SampleClass.ForMethod();

            // Assert
            Assert.Equal(10, i);
        }

        [Theory]
        [InlineData(100)]
        [InlineData(101)]
        public void Limit_Greater100_ReturnCorrectData(int value)
        {
            Assert.Equal(100, SampleClass.Limit(value));
        }
        
        [Theory]
        [InlineData(98)]
        [InlineData(99)]
        public void Limit_Smaller100_ReturnCorrectData(int value)
        {
            Assert.Equal(value, SampleClass.Limit(value));
        }
    }
}