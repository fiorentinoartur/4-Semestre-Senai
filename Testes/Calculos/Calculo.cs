using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    public static class Calculo
    {


        public static double Somar(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double Subtracao(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Divisao(double num1, double num2)
        {
            return num1 / num2;
        }
        public static double Multiplicacao(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double? Bhaskara(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new ArgumentException("O coeficiente a n'ao pode ser zero");
            }



            var delta = Math.Pow(b, 2) - (4 * a * c);
            if (delta < 0)
            {
                return null;
            }
            var x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            var x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            return Math.Max(x1, x2);

        }


        public static bool ValidarEmail(string email)
        {
            if (email.Contains("@") && email.Contains("."))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool AdicionarLivro(string livro)
        {
            List<string> listaLivros = new List<string>();
            var qtdIcinial = listaLivros.Count;

            if (string.IsNullOrEmpty(livro))
                return false;


            listaLivros.Add(livro);

            var qtdFinal = listaLivros.Count;


            return qtdFinal > qtdIcinial ? true : false;


        }

        public static double? ConverterTemperatura(double value)
        {
            return (value - 32) * (5 / 9);
        }

        public static bool AdicionarProduto(string produto)

        {
            List<Produtos> produtos = new List<Produtos>();
            produtos.Add(new Produtos { Nome = "Mouse", Quantidade = 2 });
            produtos.Add(new Produtos { Nome = "Celular", Quantidade = 1 });
            produtos.Add(new Produtos { Nome = "Notbook", Quantidade = 1 });

            if (string.IsNullOrEmpty(produto))
                return false;

            bool flag = false;
            foreach (var item in produtos)
            {
                if(item.Nome == produto)
                {
                    item.Quantidade += 1;
                    flag = true;
                }   
            }

            if (!flag)
                produtos.Add(new Produtos { Nome = produto, Quantidade = 1 });

            return true;
        }

        public static int? BuscarQuantidadeProduto(string produto)
        {
            List<Produtos> produtos = new List<Produtos>();
            produtos.Add(new Produtos { Nome = "Mouse", Quantidade = 2 });
            produtos.Add(new Produtos { Nome = "Celular", Quantidade = 1 });
            produtos.Add(new Produtos { Nome = "Notbook", Quantidade = 1 });

            var prod = produtos.FirstOrDefault(x => x.Nome == produto);

            if (prod == null)
                return null;

            return prod.Quantidade; 
        }
    }


    public class Produtos
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
    }
}
