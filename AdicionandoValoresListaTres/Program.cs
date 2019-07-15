using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdicionandoValoresListaTres
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaDeCarros = new string[2, 3];

            int IdParaLista = 0;

            InsereRegistro(ref listaDeCarros, ref IdParaLista);

            Console.ReadKey();

        }

        public static void InsereRegistro(ref string[,] listaDeCarro, ref int IdParaLista)
        {
            for (int i = 0; i < listaDeCarro.GetLength(0); i++)
            {
                if (listaDeCarro[i, 0] != null)
                {
                    continue;
                }

                Console.WriteLine("\r\nDigite o nome do carro:");
                var nomeCarro = Console.ReadLine();

                Console.WriteLine("\r\nDigite o ano do carro:");
                var anoCarro = Console.ReadLine();

                listaDeCarro[i, 0] = (IdParaLista++).ToString();

                listaDeCarro[i, 1] = nomeCarro;

                listaDeCarro[i, 2] = anoCarro;

                Console.WriteLine("Deseja continuar a lista? Sim(1) ou Não(0)");

                var continuar = Console.ReadKey().KeyChar.ToString();

                if (continuar == "0")
                    break;

                AumentaTamanhoLista(ref listaDeCarro);
            }

            Console.WriteLine("\nRegistros adicionados, seguem registros que foram adicionados:");

            for (int i = 0; i < listaDeCarro.GetLength(0); i++)
            {
                Console.WriteLine(string.Format("Registro ID: {0} - Nome do carro: {1} - Ano do carro: {2}", listaDeCarro[i, 0], listaDeCarro[i, 1], listaDeCarro[i, 2]));
            }
        }

        public static void AumentaTamanhoLista(ref string[,] ListaDeCarro)
        {
            var limiteDaLista = true;

            for (int i = 0; i < ListaDeCarro.GetLength(0); i++)
            {
                if (ListaDeCarro[i, 0] == null)
                {
                    limiteDaLista = false;
                }
            }

            if (limiteDaLista)
            {
                var listaCopia = ListaDeCarro;

                ListaDeCarro = new string[ListaDeCarro.GetLength(0) + 1, 3];

                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    ListaDeCarro[i, 0] = listaCopia[i, 0];

                    ListaDeCarro[i, 1] = listaCopia[i, 1];

                    ListaDeCarro[i, 2] = listaCopia[i, 2];
                }

                Console.WriteLine("\nO tamanho da lista foi atualizado.");
            }
        }

        public static void SuperExtra(ref string[,] listaDCarro, ref int IdParaLista)
        {
            for (int i = 0; i < listaDCarro.GetLength(0); i++)
            {

            }
        }
    }
}
