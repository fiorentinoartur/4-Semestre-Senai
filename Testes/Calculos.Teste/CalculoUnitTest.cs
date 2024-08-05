using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos.Teste
{
    public class CalculoUnitTest
    {
        //AAA : Act, Arrange, Assert
        //      Agir, Organizar e Assertir

        [Fact]
        public void TestarMetodoSomar()
        {
            //Arrange : Organizar 
            var x1 = 4.1;
            var x2 = 5.9;
            var valorEsperado = 10;

            //Act : Agir
            var soma = Calculo.Somar(x1, x2);

            //Assert : Provar
            Assert.Equal(valorEsperado, soma);

        }

        [Fact]
        public void TestarMetodoSubtrai()
        {
            var x1 = 7.1;
            var x2 = 0.1;
            var valorEsperado = 7;

            var subtracao = Calculo.Subtracao(x1, x2);

            Assert.Equal(valorEsperado, subtracao);
        }


        [Fact]
        public void TestarMetodoMultiplicar()
        {
            var x1 = 9;
            var x2 = 8;
            var valorEsperado = 72;
            var multiplicacao = Calculo.Multiplicacao(x1, x2);

            Assert.Equal(valorEsperado, multiplicacao);



        }

        [Fact]
        public void TestarDivisao()
        {
            var x1 = 8;
            var x2 = 2;

            var valorEsperado = 4;
            var divisao = Calculo.Divisao(x1, x2);

            Assert.Equal(valorEsperado, divisao);
        }

        [Fact]
        public void TestarBaskara()
        {

        }


        [Fact]
        public void AdicionarLivro()
        {
            var livro = "teste";

            var valorEsperado = true;

            var resultado = Calculo.AdicionarLivro(livro);

            Assert.Equal(valorEsperado, resultado);
        }
        [Fact]
        public void ValidarEmail()
        {
            var email = "carlaosenai.com";

            var valorEsperado = true;

            var resultado = Calculo.ValidarEmail(email);

            Assert.Equal(valorEsperado, resultado);
        }

        [Fact]
        public void ConverterTemperatura()
        {
            var valor = 0;

            var resultadoEsperado = 32;

            var resultado = Calculo.ConverterTemperatura(valor);


            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void AdicionarProduto()
        {
            var produto = "Mouse";
            var valorEsperado = true;

            var resultado = Calculo.AdicionarProduto(produto);

            Assert.Equal(valorEsperado, resultado);
        }

        [Fact]
        public void BuscarProduto()
        {
            var produto = "Mouse";
            int valorEsperado = 1;

            var resultado = Calculo.BuscarQuantidadeProduto(produto);

            Assert.Equal(valorEsperado, resultado);
        }
       
    }
}
