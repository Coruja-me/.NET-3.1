using System;
using System.ComponentModel.DataAnnotations;
using Src.Models;
using Xunit;

namespace Test
{
    public class CalcTest
    {
        Calculadora calc = new Calculadora();
        [Theory]
        [InlineData(5, 10, 15)]
        public void SumTest(int x, int y, int z)
        {
            // Arrange/Act
            int result = calc.Sum(x, y);

            // Assert

            Assert.Equal(z, result);

        }
        [Theory]
        [InlineData(10, 5, 5)]
        public void SubTest(int x, int y, int z)
        {
            // Arrange/Act
            int result = calc.Sub(x, y);

            // Assert

            Assert.Equal(z, result);

        }
        [Theory]
        [InlineData(5, 10, 50)]
        public void MultTest(int x, int y, int z)
        {
            // Arrange/Act
            int result = calc.Mult(x, y);

            // Assert

            Assert.Equal(z, result);

        }
        [Theory]
        [InlineData(10, 5, 2)]
        public void DivTest(int x, int y, int z)
        {
            // Arrange/Act
            int result = calc.Div(x, y);

            // Assert

            Assert.Equal(z, result);

        }
        [Fact]
        public void DivZeroTest()
        {
            // Assert

            Assert.Throws<DivideByZeroException>(() => calc.Div(5, 0));
        }
        [Fact]
        public void HistTest()
        {
            calc.Sum(1, 2);
            calc.Sum(2, 4);
            calc.Sum(3, 5);
            calc.Sum(8, 2);
            calc.Sum(1, 1);

            var lista = calc.Hist();
            
            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}
