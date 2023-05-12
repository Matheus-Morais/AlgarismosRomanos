using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Conversor.Testes
{
    public class CalcTests
    {
        private readonly ITestOutputHelper _output;

        public CalcTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void Should_Add_Two_Numbers()
        {
            // Arrange - Arrumar
            var a = 2;
            var b = 3;
            var expected = 5;

            // Act - Agir
            var resultado = Calc.Adicionar(a, b);

            // Assert - Conferir
            Assert.Equal(expected, resultado);

            _output.WriteLine("Resultado da Soma: " + resultado);
        }

        [Fact]
        
        public void Should_Substract_Two_Numbers()
        {
            var c = 10;
            var d = 20;
            var expected = 10;

            var resposta = Calc.Subtrair(d, c);

            Assert.Equal(expected, resposta);

            _output.WriteLine("Resultado da Subtração: " + resposta);
        }
    }

    public class Calc
    {
        public static int Adicionar(int a, int b) => a + b;
        public static int Subtrair(int a, int b) => a - b;
    }
}
