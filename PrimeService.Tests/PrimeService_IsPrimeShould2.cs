﻿using System;
using Prime2.Services;
using Xunit;

namespace Prime2.UnitTests.Services
{
    public class PrimeService_IsPrimeShould2
    {
        private readonly PrimeService2 _primeService;

        public PrimeService_IsPrimeShould2()
        {
            _primeService = new PrimeService2();
        }

        #region Sample_TestCode
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }
        #endregion

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void IsPrime_PrimesLessThan10_ReturnTrue(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.True(result, $"{value} should be prime");
        }

        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(9)]
        public void IsPrime_NonPrimesLessThan10_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }
    }
}
