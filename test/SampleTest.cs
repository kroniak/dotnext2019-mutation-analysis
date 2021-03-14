using System;
using System.Threading.Tasks;
using library;
using Xunit;

namespace test
{
    public class SampleTest
    {
        [Theory]
        [InlineData(false, false)]
        // [InlineData (true, false)]
        // [InlineData (false, true)]
        public void Method_Data_ReturnFalse(bool a, bool b)
        {
            // Act
            var result = SampleClass.Method(a, b);

            // Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData(false)]
        public void LibraryMethod_NegativeData_ThrowException(bool val)
        {
            // Act
            var ex = Assert.Throws<Exception>(() => SampleClass.LibraryMethod(val));

            // Assert
            Assert.Equal("Something happened", ex.Message);
            Assert.Equal("USER_DB is not path pattern user_adminXXXX (Parameter 'con')",
                ex.InnerException?.Message);
        }

        [Theory]
        [InlineData(true)]
        public void LibraryMethod_PositiveData_ReturnCorrectString(bool val)
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
        [InlineData(0)]
        [InlineData(98)]
        [InlineData(99)]
        public void Limit_Smaller100_ReturnCorrectData(int value)
        {
            Assert.Equal(value, SampleClass.Limit(value));
        }

        [Theory]
        [InlineData(-1)]
        public void Limit_Smaller0_ThrowException(int value)
        {
            Assert.Throws<ArgumentException>(() => SampleClass.Limit(value));
        }

        [Fact]
        public async Task GetValue_ReturnCorrectDataAsync()
        {
            //... mock data
            var result = await SampleClass.GetValueAsync("some");

            Assert.Equal("some", result);
            //... some other assertion
        }
    }
}