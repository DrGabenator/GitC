using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorDeIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            BemVindo();

            var opcaoDoMenu = MenuDeInicializacao();


            while (opcaoDoMenu != 2)
            {
                var nomePessoa = ChecarNome();

                if (opcaoDoMenu == 1)
                {
                    ChecarIdadeELegalidade(nomePessoa);
                    opcaoDoMenu = 2;
                }
            }
        }

        /// <summary>
        /// Método que mostra um menu de bem vindo ao usuário
        /// </summary>
        public static void BemVindo()
        {
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*    BEM VINDO AO SISTEMA PARA CHECAR SE VOCÊ PODE  *");
            Console.WriteLine("*    TOMAR AQUELA BIRITINHA COM OS AMIGUINHOS!      *");
            Console.WriteLine("*****************************************************");
        }

        /// <summary>
        /// Método que mostra um menu de inicialização para o usuário fazer sua escolha
        /// </summary>
        /// <returns>Retorna a escolha do usuário</returns>
        public static int MenuDeInicializacao()
        {
            Console.WriteLine("1- Se você deseja verificar se você tem 18 anos ou mais e pode consumir álcool.");
            Console.WriteLine("2- Se você deseja sair do sistema.");
            Console.WriteLine("Digite a opção desejada:");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int escolha);

            return escolha;
        }

        /// <summary>
        /// Método que pergunta o nome da pessoa e armazena esse valor
        /// </summary>
        /// <returns>Retorna o nome que foi digitado pelo usuário</returns>
        public static string ChecarNome()
        {
            Console.WriteLine("\nVamos confirmar seu nome!");
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();

            return nome;
        }

        /// <summary>
        /// Método para checar a idade e comparar para ver onde a pessoa se encaixa nas limitações
        /// </summary>
        /// <param name="nome"></param>
        public static void ChecarIdadeELegalidade(string nome)
        {
            Console.WriteLine("\nVamos checar a sua idade!");
            Console.WriteLine("Digite sua idade:");

            int.TryParse(Console.ReadLine().ToString(), out int idade);

            if (idade <= 18)
            {
                Console.Clear();
                Console.WriteLine(@"
                                    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▄▄▄░░░░░
                                    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░███▀█░░░░
                                    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░███░██░░░
                                    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░███░░██░░░
                                    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░▄██░░░░██░░
                                    ░░░░░░░░░░░░░░░░▄▄█▀▀▀▀█▄▄▄▄███▄░░░██░░
                                    ░░░░░░░░░░░░░▄█▀░░░░░░░░░▀▀▀▀█░▀█░░██░░
                                    ░░░░░░░░░░░░█▀░░░░░░░░░░░░░░░▀█▄█▀▀▀░░░
                                    ░░░░░░░░░░░▄▀░░░░░░░░░░░░░░░░▀█▄░░░░░░░
                                    ░░░░░░░░░░░▀█▄░█░░▄▀░░░░░░░▄▄█░░░░░░░░░
                                    ░░░░░░░░▄▄▄▄█▀▀▀██▄▄░░░░░░▄▀░░░░░░░░░░░
                                    ░░░░▄▄██▄▀▀░░░░░█▀░░░░░░▄██▄░░░░░░░░░░░
                                    ░░▄██▀▀░░░░░░░░▄█░░░░░▄█▀▄█░▀▀█▄▄▄▄▄▄▄▄
                                    ░██▀░░░░░░░░▄██░░░░░░▄▀▄▄▀░░░░░░░░░░░░░
                                    █▀▀░░░░░░▄█▀▄░▀▄▄▄▄██▀▀▀░░░░░█░░░░░░░░░
                                    █░░░░░▄▄▀░░░░█░░░░░░░░░░░░░░░▀░░░░░░░░░
                                    ░▀▀▀▀▀▀░░░░░░░█░░░░░░░░░░░░░░░▀▀█▀▀▀▀▀▀
                                    ░░░░░░░░░░░░░░█░░░░░░░░░░░░░░░░█▀░░░░░░
                                    ░░░░░░░░░░░░░░█░░░░░░░░░░░░░░░▄█░░░░░░░");
                Console.WriteLine($"Infelizmente {nome}, você tem {idade} anos e não pode ingerir bebidas alcoólicas ainda.");
            }

            if (idade >= 19 && idade < 100)
            {
                Console.Clear();
                Console.WriteLine(@"
                                    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
                                    ░░░░░░░▄▄▀▀▀▀▀▀▀▀▀▀▄▄█▄░░░░▄░░░░█░░░░░░░
                                    ░░░░░░█▀░░░░░░░░░░░░░▀▀█▄░░░▀░░░░░░░░░▄░
                                    ░░░░▄▀░░░░░░░░░░░░░░░░░▀██░░░▄▀▀▀▄▄░░▀░░
                                    ░░▄█▀▄█▀▀▀▀▄░░░░░░▄▀▀█▄░▀█▄░░█▄░░░▀█░░░░
                                    ░▄█░▄▀░░▄▄▄░█░░░▄▀▄█▄░▀█░░█▄░░▀█░░░░█░░░
                                    ▄█░░█░░░▀▀▀░█░░▄█░▀▀▀░░█░░░█▄░░█░░░░█░░░
                                    ██░░░▀▄░░░▄█▀░░░▀▄▄▄▄▄█▀░░░▀█░░█▄░░░█░░░
                                    ██░░░░░▀▀▀░░░░░░░░░░░░░░░░░░█░▄█░░░░█░░░
                                    ██░░░░░░░░░░░░░░░░░░░░░█░░░░██▀░░░░█▄░░░
                                    ██░░░░░░░░░░░░░░░░░░░░░█░░░░█░░░░░░░▀▀█▄
                                    ██░░░░░░░░░░░░░░░░░░░░█░░░░░█░░░░░░░▄▄██
                                    ░██░░░░░░░░░░░░░░░░░░▄▀░░░░░█░░░░░░░▀▀█▄
                                    ░▀█░░░░░░█░░░░░░░░░▄█▀░░░░░░█░░░░░░░▄▄██
                                    ░▄██▄░░░░░▀▀▀▄▄▄▄▀▀░░░░░░░░░█░░░░░░░▀▀█▄
                                    ░░▀▀▀▀░░░░░░░░░░░░░░░░░░░░░░█▄▄▄▄▄▄▄▄▄██
                                    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");

            Console.WriteLine($"Felizmente {nome}, você já tem {idade} anos e pode ingerir bebidas alcoólicas!");
            }
            if (idade >= 100)
            {
                Console.Clear();
                Console.WriteLine(@"
                                    ─────────────────▄▄▄▄▄▄▄▄▄▄▄
                                    ────────────▄▄▀▀▀░░░░░░░░░░░▀▄▄
                                    ────────▄▄▀▀░░░░░░░▄▄▄▄▄▄▄░░░░░▀▄
                                    ──────▄▀░░░░░░░░░▄▄▄▄▄▄▄▄▄▄▄░░░░░█
                                    ────▄▀░░░░░▄▄▄▄▄▄▄░░░░░░░░░░░▄▄▄▄▄█▄▄
                                    ───▄▀░▐▌░░░░░░░░░░▀▀░░░░░░░▀▀░░░░░░█
                                    ──█░░░▀░░░░░░░▄▀▀▀▄░░░░▄░░░░▄▀▀▀▄░░▐▌
                                    ─█░░░░░░▄▄▄░░▐░░▄░░▌░░░░▀▄░▐░░▄░░▌░░█
                                    ▐▌░░░░▀▀░░░░▄░▀▄▄▄▀░░░░░░░▌░▀▄▄▄▀░░░▐▌
                                    █░░░░░░░░░░░░▀▄▄▄░░░░░░░░▐░░░░░▄▄▄▀░░█
                                    █░░░░▄▀░░░░░░░▄▄░░░░░░▄▀░▐░░░▄▄░░░░░░█
                                    ▐▌░░▀░░░░░░░▄▀░░░▐▀░░░░░░░▀▌░░░▀▄░░░░█
                                    ▐▌░░░▐░░░░░▐▌░░░░░▀█░░░░░░░▌░░░░█░░░░█
                                    ─█░░░░░░░░░░░░░░▄░░▀▀▄▄▄▄▀▀░▀▄░░░░░░░█
                                    ─▐▌░░░░░░░░░░░▄▀░░░░▄▄▄▄▄▄░░░░▌░░░░░░█
                                    ──█░░░░░░░░░░▐░░░░▄▀░░░░░░▀▄░░▌░░░░░▐▌
                                    ──▐▌░░░░░░░░░▐░░░░▀░░░▀▀░░░▀░░░░░░░░█
                                    ───█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▐▌
                                    ───▐▌░░░░░░░░░▄███████▄░░░░▄████████▄
                                    ────▀▄████████████▀█████▄▄████████▀██
                                    ───▄██▀▄░░░░░███▀▄██████▀▀██████▀▄███
                                    ───▀▀───▀▀▀▀▀▀█████████▀▀▀▀█████████▀
                                    ───────────────▀▀▀▀▀▀▀──────▀▀▀▀▀▀▀");
                Console.WriteLine($"Olha {nome}, você já tem {idade} e você pode ingerir bebidas alcoólicas mas não é recomendado...");
            }
            Console.ReadKey();
        }
    }
}
