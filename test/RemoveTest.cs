using System;
using System.Collections.Generic;
using library;
using Xunit;

namespace test
{
    public class RemoveTest
    {
        private readonly IList<Value> _container = new List<Value>
        {
            new(1),
            new(2),
            new(3)
        };

        private readonly IList<Value> _containerD = new List<Value>
        {
            new(1),
            new(1),
            new(2),
            new(3)
        };

        [Fact]
        public void Remove_ExistT_TRemoved()
        {
            // Arrange
            var expected = _container.Count;
            var data = _container[1];

            // Act
            RemoveClass.Remove(_container, data);

            // Assert
            Assert.Equal(expected - 1, _container.Count);
        }

        [Fact]
        public void Remove_NotExistT_TNotRemoved()
        {
            // Arrange
            var expected = _container.Count;
            var data = new Value(4);

            // Act
            RemoveClass.Remove(_container, data);

            // Assert
            Assert.Equal(expected, _container.Count);
        }

        [Fact]
        public void RemoveSecond_ExistT_TRemoved()
        {
            // Arrange
            var expected = _container.Count;
            var data = new Value(_container[1].SomeField);

            // Act
            RemoveClass.RemoveSecond(_container, data);

            // Assert
            Assert.Equal(expected - 1, _container.Count);
        }

        [Fact]
        public void RemoveSecond_NotExistT_TNotRemoved()
        {
            // Arrange
            var expected = _container.Count;
            var data = new Value(4);

            // Act
            RemoveClass.RemoveSecond(_container, data);

            // Assert
            Assert.Equal(expected, _container.Count);
        }

        [Fact]
        public void RemoveThird_ExistT_TRemoved()
        {
            // Arrange
            var container = _containerD;
            var expected = container.Count;
            var data = new Value(container[2].SomeField);

            // Act
            RemoveClass.RemoveThird(container, data);

            // Assert
            Assert.Equal(expected - 1, container.Count);
        }

        [Fact]
        public void RemoveThird_ExistTDouble_ThrowsException()
        {
            // Arrange
            var container = _containerD;
            var expected = container.Count;
            var data = new Value(container[1].SomeField);

            // Act
            Assert.Throws<InvalidOperationException>(() => RemoveClass.RemoveThird(container, data));

            // Assert
            Assert.Equal(expected, container.Count);
        }

        [Fact]
        public void RemoveThird_NotExistT_TNotRemoved()
        {
            // Arrange
            var container = _containerD;
            var expected = container.Count;
            var data = new Value(4);

            // Act
            RemoveClass.RemoveThird(container, data);

            // Assert
            Assert.Equal(expected, container.Count);
        }
    }
}