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
                if (opcaoDoMenu == 1)
                {
                    ChecarIdadeELegalidade();
                }
            }
        }

        public static void BemVindo()
        {
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*    BEM VINDO AO SISTEMA PARA CHECAR SE VOCÊ PODE  *");
            Console.WriteLine("*    TOMAR AQUELA BIRITINHA COM OS AMIGUINHOS!      *");
            Console.WriteLine("*****************************************************");
        }

        public static int MenuDeInicializacao()
        {
            Console.WriteLine("1- Se você deseja verificar se você tem 18 anos ou mais e pode consumir álcool.");
            Console.WriteLine("2- Se você deseja sair do sistema.");
            Console.WriteLine("Digite a opção desejada:");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int escolha);

            return escolha;
        }

        public static void ChecarIdadeELegalidade()
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
                Console.WriteLine($"Infelizmente você tem {idade} anos e não pode ingerir bebidas alcoólicas ainda.");
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

            Console.WriteLine($"Felizmente você já tem {idade} anos e pode ingerir bebidas alcoólicas!");
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
                Console.WriteLine($"Olha, você já tem {idade} e você pode ingerir bebidas alcoólicas mas não é recomendado...");
            }
        }
    }
}
