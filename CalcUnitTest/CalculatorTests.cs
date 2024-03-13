using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace CalcUnitTest
{
    public class CalculatorTests
    {
        [Fact]
        public void TestAddTwoNumbers()
        {
            int x = 20;
            int y = 40;
            int exeptedValue = 60;

            int result = Calculators.Add(x, y);

            Assert.Equal(exeptedValue, result);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 4)]
        [InlineData(3, 4, 7)]
        public void TestAddTwoNumbersWithTheory(int x, int y, int exeptedValue)
        {
            int result = Calculators.Add(x, y);
            Assert.Equal(result, exeptedValue);
        }

        [Fact]
        public void TestSubstractTwoNumbers()
        {
            int x = 3;
            int y = 2;
            int exeptedValue = 1;

            int result = Calculators.Substract(x, y);

            Assert.Equal(exeptedValue, result);
        }


        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(5, 4, 3)]
        [InlineData(7, 4, 3)]
        public void TestSubstractTwoNumbersWithTheory(int x, int y, int exeptedValue)
        {
            int result = Calculators.Substract(x, y);

            Assert.Equal(exeptedValue, result);
        }

        [Fact]
        public void TestMultipleTwoNumbers()
        {
            int x = 2;
            int y = 4;
            int exeptedValue = 8;

            int result = Calculators.Multiple(x, y);

            Assert.Equal(exeptedValue, result);
        }

        [Theory]
        [InlineData(3, 2, 6)]
        [InlineData(3, 4, 7)]
        [InlineData(1, 2, 2)]
        public void TestMultipleWithTheory(int x, int y, int exeptedValue)
        {
            int result = Calculators.Multiple(x, y);

            Assert.Equal(exeptedValue, result);
        }

        [Fact]
        public void TestDevideTwoNumbers()
        {
            int x = 4;
            int y = 2;
            int exeptedValue = 2;

            int result = Calculators.Devide(x, y);

            Assert.Equal(exeptedValue, result);
        }

        [Theory]
        [InlineData(3, 0, 0)]
        [InlineData(6, 2, 3)]
        [InlineData(3, 2, 1)]
        public void TestDevideWithTheory(int x, int y, int exeptedValue)
        {
            if (y == 0)
            {
                Assert.Throws<DivideByZeroException>(() => Calculators.Devide(x, y));
            }
            else
            {
                var result = Calculators.Devide(x, y);
                Assert.Equal(exeptedValue, result);
            }
        }
    }
}
