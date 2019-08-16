using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] baseDeLivros = new string[2, 5];

            int IDLivros = 0;

            var opcaoMenu = MostrarMenu();

            while (true)
            {
                switch (opcaoMenu)
                {
                    case "1":
                        {
                            AdicionarLivros(ref baseDeLivros, ref IDLivros);
                        }break;
                    case "2":
                        {
                            RemoverLivros(ref baseDeLivros);
                        }break;
                    case "3":
                        {
                            ListarLivros(baseDeLivros);
                        }
                        break;
                    case "4":
                        {
                            ListarLivros(baseDeLivros, "true");
                        }
                        break;
                    case "5":
                        {
                            return;
                        }
                }
                opcaoMenu = MostrarMenu();
            }


        }

        /// <summary>
        /// Método para mostra o menu inicial
        /// </summary>
        /// <returns>Retorna a opcao para o menu</returns>
        public static string MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("**************************************");
            Console.WriteLine("*     Bem vindo ao menu inicial!     *");
            Console.WriteLine("**************************************");
            Console.WriteLine("* 1- Adicionar livros                *");
            Console.WriteLine("* 2- Remover livros                  *");
            Console.WriteLine("* 3- Listar livros                   *");
            Console.WriteLine("* 4- Listar os livros removido       *");
            Console.WriteLine("* 5- Sair                            *");
            Console.WriteLine("**************************************");
            Console.WriteLine("*     Selecione a opção desejada     *");
            Console.WriteLine("**************************************");

            return Console.ReadLine();
        }

        /// <summary>
        /// Método que insere mais livros na base de dados da biblioteca
        /// </summary>
        /// <param name="baseDeLivros">Base de dados como ref para alterar os métodos</param>
        /// <param name="IDlivros">ID dos livros como ref para também alterar os métodos</param>
        public static void AdicionarLivros(ref string[,] baseDeLivros, ref int IDlivros)
        {
            Console.Clear();

            Console.WriteLine("**************************************************");
            Console.WriteLine("*   Área para adicionar um livro a biblioteca.   *");
            Console.WriteLine("**************************************************");

            Console.WriteLine("Digite o nome do livro:");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite o nome do autor do livro:");
            var autor = Console.ReadLine();

            AumentarBase(ref baseDeLivros);

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if(baseDeLivros[i,0] != null)
                {
                    continue;
                }

                baseDeLivros[i, 0] = (IDlivros++).ToString();
                baseDeLivros[i, 1] = nome;
                baseDeLivros[i, 2] = autor;
                baseDeLivros[i, 3] = "true";
                baseDeLivros[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                break;
            }

            Console.WriteLine("O livro foi adicionado a nossa biblioteca com sucesso!");
            Console.WriteLine("Para retornar ao menu inicial, aperte qualquer tecla no seu teclado.");
            Console.ReadKey();
        }

        /// <summary>
        /// Método para mostrar a lista de livros que estão disponíveis
        /// </summary>
        /// <param name="baseDeLivros">Base de dados dos livros para ler e mostrar ao usuário</param>
        /// <param name="naoEstaNaBiblioteca">Quando true, mostra os valores que não estão na biblioteca</param>
        public static void ListarLivros(string[,] baseDeLivros, string naoEstaNaBiblioteca = "false")
        {
            Console.Clear();

            if(naoEstaNaBiblioteca == "true")
            {
                Console.WriteLine("Esses livros não se encontram mais em nossa biblioteca.");
            }

            else
            Console.WriteLine("Esses são os livros que temos em nossa biblioteca:");

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if(baseDeLivros[i,3] != naoEstaNaBiblioteca)
                Console.WriteLine($"ID: {baseDeLivros[i,0]} /" +
                                  $" Nome do livro: {baseDeLivros[i,1]} /" +
                                  $" Autor do livro: {baseDeLivros[i,2]} /" +
                                  $" Data de alteração no sistema: {baseDeLivros[i,4]}");
            }

            Console.WriteLine("Para retornar ao menu inicial, aperte qualquer tecla no seu teclado.");
            Console.ReadKey();
        }

        /// <summary>
        /// Método para aumentar a base de dados caso exceder o limite da lista
        /// </summary>
        /// <param name="baseDeLivros">Retorna a base de dados</param>
        public static void AumentarBase(ref string[,] baseDeLivros)
        {
            var limiteBiblioteca = true;

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if(baseDeLivros[i,0] == null)
                {
                    limiteBiblioteca = false;
                }
            }

            if (limiteBiblioteca)
            {
                var copiaBiblioteca = baseDeLivros;

                baseDeLivros = new string[baseDeLivros.GetLength(0) + 1, 5];

                for (int i = 0; i < copiaBiblioteca.GetLength(0); i++)
                {
                    baseDeLivros[i, 0] = copiaBiblioteca[i, 0];
                    baseDeLivros[i, 1] = copiaBiblioteca[i, 1];
                    baseDeLivros[i, 2] = copiaBiblioteca[i, 2];
                    baseDeLivros[i, 3] = copiaBiblioteca[i, 3];
                    baseDeLivros[i, 4] = copiaBiblioteca[i, 4];
                }

                Console.WriteLine("O tamanho da biblioteca foi expandido com sucesso!");
            }
        }

        /// <summary>
        /// Método para remover livros da base de dados
        /// </summary>
        /// <param name="baseDeLivros">Nova base sem os livros removidos</param>
        public static void RemoverLivros(ref string[,] baseDeLivros)
        {
            Console.Clear();

            Console.WriteLine("*************************************************");
            Console.WriteLine("*   Área para remover um livro da biblioteca.   *");
            Console.WriteLine("*************************************************");

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if(baseDeLivros[i,3] != "false")
                {
                    Console.WriteLine($"ID: {baseDeLivros[i, 0]} /" +
                                  $" Nome do livro: {baseDeLivros[i, 1]} /" +
                                  $" Autor do livro: {baseDeLivros[i, 2]}");
                }
            }

            Console.WriteLine("Digite o ID do livro a ser removido da biblioteca.");
            var remocao = Console.ReadLine();

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if(baseDeLivros[i,0] != null && baseDeLivros[i,0] == remocao)
                {
                    baseDeLivros[i, 3] = "false";
                    baseDeLivros[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                }
            }

            Console.WriteLine("O livro foi removido da nossa biblioteca com sucesso!");
            Console.WriteLine("Para retornar ao menu inicial, aperte qualquer tecla no seu teclado.");
            Console.ReadKey();
        }
    }
}
