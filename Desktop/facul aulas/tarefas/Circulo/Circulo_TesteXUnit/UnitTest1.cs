using Circulo;
using System;
using Xunit;

namespace Circulo_TesteXUnit
{
    public class OperacaoTeste
    {
        


            [Theory]
            [InlineData(2, 5,)]
            [InlineData(2, 8,)]
            [InlineData(10, 5,)]
        
        public void TesteSoma1(double a, double r,const double PI=3,1416, double resultadoteste)
        {
                //arrange
            int resultado;
            Opera��o OperacaoTeste = new Opera��o();
            //ACT
            resultado = OperacaoTeste.Soma(a, r, PI);
                //Assert
            Assert.Equal(resultado, resultadoteste);

        }
    }
}