using System;
using System.Collections.Generic;
using HandsOn.Business.Services;
using Xunit;

namespace HandsOn.Tests
{
    public class DivisorTests
    {
        [Fact]
        public void Divisor_DivisorsFromIntegerResultMustBeEqualDemo()
        {
            // Arrange
            var divisor = new DivisorService();
            var acceptedAnswer = new List<int>() { 1, 2, 4, 5, 8, 10, 20, 40 };

            // Act
            var result = divisor.DivisorsFromInteger(40);

            // Assert
            Assert.Equal(acceptedAnswer, result);
        }

        [Fact]
        public void Divisor_DivisorsPrimesFromIntegerResultMustBeEqualDemo()
        {
            // Arrange
            var divisor = new DivisorService();
            var listOfPrimes = new List<int>() { 1, 2, 4, 5, 8, 10, 20, 40 };
            var acceptedAnswer = new List<int>() { 2, 5 };

            // Act
            var result = divisor.PrimeDivisorsFromList(listOfPrimes);

            // Assert
            Assert.Equal(acceptedAnswer, result);
        }

        [Fact]
        public void Divisor_IntegerIsPrime()
        {
            // Arrange
            var divisor = new DivisorService();

            // Act
            var result = divisor.IntegerIsPrime(2);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Divisor_IntegerIsNotPrime()
        {
            // Arrange
            var divisor = new DivisorService();

            // Act
            var result = divisor.IntegerIsPrime(1);

            // Assert
            Assert.False(result);
        }
    }
}
