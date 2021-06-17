using ExBhaskara;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(3, -15, 12)]
        [InlineData(9, -24, 16)]
        [InlineData(1, -2, 4)]
        public void TesteCalculo(float a, float b, float c,  float resultadodoteste)
        {
            //arrange
            float resultado;

            Exercicio ExercicioTeste = new Exercicio();
            //act
            resultado = ExercicioTeste.Calculo(a, b, c);
            //assert
            Assert.Equal(resultado, resultadodoteste);

        }
    }
}
}
