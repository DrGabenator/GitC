using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecaOnlineNasa3PONTOZERO
{
    class Program
    {
        static string[,] baseDeLivros;
        static void Main(string[] args)
        {
            CarregaBaseDeDados();

            var opcaoMenu = MenuPrincipal();

            while (opcaoMenu != 3)
            {
                if (opcaoMenu == 1)
                {
                    AlocarUmLivro();
                }

                if (opcaoMenu == 2)
                {
                    DesalocarUmLivro();
                }

                opcaoMenu = MenuPrincipal();
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Método que vai carregar a parte inicial do sistema e escrever no console
        /// </summary>
        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine("##################################################################");
            Console.WriteLine("#________________________________________________________________#");
            Console.WriteLine("#Seja bem vindo ao Sistema Nasa 3PONTOZERO de alocação de livros.#");
            Console.WriteLine("#________________________________________________________________#");
            Console.WriteLine("#            Desenvolvido pelos Marcianos de Plutão!             #");
            Console.WriteLine("#________________________________________________________________#");
            Console.WriteLine("##################################################################");
        }
        
        /// <summary>
        /// Método que mostra o conteudo do menu e as opções de escolha.
        /// </summary>
        /// <returns>Retorna o valor do menu escolhido em um tipo inteiro.</returns>
        public static int MenuPrincipal()
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine("Inicialização.");
            Console.WriteLine("O que você deseja realizar, humano?");
            Console.WriteLine("1 - Alocar um livro.");
            Console.WriteLine("2 - Devolver um livro.");
            Console.WriteLine("3 - Sair do sistema.");
            Console.WriteLine("Digite o número desejado:");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }

        /// <summary>
        /// Método que carrega a base de dados dentro do sistema.
        /// </summary>
        public static void CarregaBaseDeDados()
        {
            baseDeLivros = new string[2, 2]
            {
                {"O pequeno","Sim!"},
                {"O grande","Não!"}
            };
        }

        /// <summary>
        /// Método que retorna se um livro pode ser alocado.
        /// </summary>
        /// <param name="nomeLivro">Nome do livro a ser pesquisado</param>
        /// <returns>Retorna verdadeiro em caso o livro estiver livre para alocação.</returns>
        public static bool PesquisaLivroParaAlocacao(string nomeLivro)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (nomeLivro == baseDeLivros[i, 0])
                {
                    Console.WriteLine($"O livro: {nomeLivro}" +
                        $" pode ser alocado? {baseDeLivros[i, 1]}");

                    return baseDeLivros[i, 1] == "Sim!";
                }
            }

            return false;
        }

        /// <summary>
        /// Método para alterar a informação de alocação do livro;
        /// </summary>
        /// <param name="nomeLivro">Nome do livro</param>
        /// <param name="alocar">Valor booleano que define se o livro está ou não disponível.</param>
        public static void AlocarLivro(string nomeLivro,bool alocar)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (nomeLivro == baseDeLivros[i, 0])
                {
                    baseDeLivros[i,1] = alocar? "Não!" : "Sim!";
                }
            }
            Console.Clear();
            MostrarListaDeLivros();
            Console.WriteLine("Livro atualizado com sucesso!");
        }

        /// <summary>
        /// Método que mostra todo o menu de alocação do sistema
        /// </summary>
        public static void AlocarUmLivro()
        {
            MostrarMenuInicialLivros("Alocar um livro:"); 

            var nomedolivro = Console.ReadLine();
            if (PesquisaLivroParaAlocacao(nomedolivro))
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja alocar o livro? Para sim(1) para não(0)");

                AlocarLivro(nomedolivro, Console.ReadKey().KeyChar.ToString() == "1");

                MostrarListaDeLivros();

                Console.ReadKey();
            }
        }

        /// <summary>
        /// Método que mostra a lista de livros atualizado.
        /// </summary>
        public static void MostrarListaDeLivros()
        {
            for (int i = 0; i<baseDeLivros.GetLength(0); i++)
                {
                    Console.WriteLine($"Nome: {baseDeLivros[i, 0]} Disponível:{baseDeLivros[i, 1]}");
                }
        }

        public static void DesalocarUmLivro()
        {
            MostrarMenuInicialLivros("Desalocar um livro:");

            MostrarListaDeLivros();

            var nomedolivro = Console.ReadLine();
            if (!PesquisaLivroParaAlocacao(nomedolivro))
            {
                Console.Clear();
                Console.WriteLine("Você deseja desalocar o livro? Para sim(1) para não(0)");

                AlocarLivro(nomedolivro, Console.ReadKey().KeyChar.ToString() == "0");

                MostrarListaDeLivros();

                Console.ReadKey();
            }
        }

        public static void MostrarMenuInicialLivros(string operacao)
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine($"Menu - {operacao}");
            Console.WriteLine("Digite o nome do livro para realizar a operação:");
        }
    }
}
