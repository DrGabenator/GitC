using MinhaPrimeiraListaTipada.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraListaTipada
{
    class Program
    {
        static void Main(string[] args)
        {
            //O indicador <T> o tipo da minha lista com isso temos uma lista de lanches
            List<Lanche> minhaLista = new List<Lanche>();

            //Adiciono na minha lista um pão de queijo

            for (int i = 0; i < 5; i++)
            {
                /*Console.WriteLine("Digite o nome do lanche: ");
                var nome = Console.ReadLine();
                Console.WriteLine("Digite a quantidade do lanche: ");
                int.TryParse(Console.ReadLine(), out int quantidade);
                Console.WriteLine("Digite o valor do lanche: ");
                double.TryParse(Console.ReadLine(), out double valor);*/

                minhaLista.Add(new Lanche()
                {
                    Nome = RetornaValores("Nome"),
                    Quantidade = int.Parse(RetornaValores("Quantidade")),
                    Valor = double.Parse(RetornaValores("Valor"))
                });

                Console.Clear();
            }

            //Aqui ando pela minha lista para poder apresentar em tela os valores
            //item in significa que ele já é um índice da minha lista bonitinho
            foreach (Lanche item in minhaLista)
            {
                Console.WriteLine($"Lanches disponíveis: {item.Nome}, Quantidade disponível: {item.Quantidade}, Valor: R${item.Valor}");
            }

            Console.WriteLine("Removendo item");

            foreach (Lanche item in minhaLista)
            {
                if (item.Quantidade == 9)
                {
                    minhaLista.Remove(item);
                    break;
                }

            }


            foreach (Lanche item in minhaLista)
            {
                Console.WriteLine($"Lanches disponíveis: {item.Nome}, Quantidade disponível: {item.Quantidade}, Valor: R${item.Valor}");
            }

            Console.ReadKey();

        }

        public static string RetornaValores(string nome)
        {
            Console.WriteLine($"Informe o valor para o campo:{nome}");
            return Console.ReadLine();

        }
    }
}
