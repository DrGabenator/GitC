using Listar_meus_carros.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listar_meus_carros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carro> minhaListaCarros = new List<Carro>();

            while (true)
            {
                Console.WriteLine("Digite o número desejável para realizar a operação: ");
                Console.WriteLine("1 - Listar os carros");
                Console.WriteLine("2 - Adicionar carros a lista");
                Console.WriteLine("3 - Sair");

                int.TryParse(Console.ReadLine(), out int opcao);

                switch (opcao)
                {

                    case 1:
                        {
                            foreach (Carro item in minhaListaCarros)
                            {
                                Console.WriteLine($"O modelo do carro é: {item.Modelo}\n" +
                                    $"O ano do carro é: {item.Ano}\n" +
                                    $"A placa do carro é: {item.Placa}\n" +
                                    $"Os pulsões pugmáticos de potência do carro é de: {item.Cv}");
                            }
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        {
                            minhaListaCarros.Add(new Carro()
                            {
                                Modelo = RetornaValores("Modelo"),
                                Ano = int.Parse(RetornaValores("Ano")),
                                Placa = RetornaValores("Valor"),
                                Cv = int.Parse(RetornaValores("Pulsões pugmáticos de potência"))
                            });
                        }
                        break;
                    case 3:
                        {
                            return;
                        }
                }
                Console.Clear();

            }
        }
        public static string RetornaValores(string nome)
        {
            Console.WriteLine($"Informe o valor para o campo:{nome}");
            return Console.ReadLine();

        }
    }
}
