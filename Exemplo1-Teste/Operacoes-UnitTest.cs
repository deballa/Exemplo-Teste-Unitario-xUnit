using Exemplo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Exemplo1_Teste
{
    public class Operacoes_UnitTest
    {
        [Fact]
        public void deveSomarDoubleRetornarDouble()
        {
            //Arrange
            var valor1 = 5.9;
            var valor2 = 9.1;
            var esperado = 15;

            //Act
            var obtido = Operacoes.somar(valor1, valor2);

            //Assert
            Assert.Equal(esperado, obtido);

        }

        [Fact]
        public void deveSubtrairDoubleRetornarDoube()
        {
            //Arrange
            var valor1 = 10.5;
            var valor2 = 9.5;
            var esperado = 1;

            //Act
            var obtido = Operacoes.subtrair(valor1, valor2);

            //Assert
            Assert.Equal(esperado, obtido);

        }

        [Fact]
        public void deveMultiplicarDoubleRetornarDoube()
        {
            //Arrange
            var valor1 = 2.36;
            var valor2 = 5.81;
            var esperado = 13.71;

            //Act
            var obtido = Operacoes.multiplicar(valor1, valor2);

            //Assert
            Assert.Equal(esperado, obtido, 2);

        }

        [Fact]
        public void deveDividirrDoubleRetornarDoube()
        {
            //Arrange
            var valor1 = 4.44;
            var valor2 = 2.22;
            var esperado = 2;

            //Act
            var obtido = Operacoes.dividir(valor1, valor2);

            //Assert
            Assert.Equal(esperado, obtido, 2);

        }
    }
}
