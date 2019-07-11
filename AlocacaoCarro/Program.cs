using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlocacaoCarro
{
    class Program
    {
        static string[,] baseDeVeiculos;
        static void Main(string[] args)
        {
            CarregaBaseDeCarros();

            BemVindo();

            LerApagar();

            Desenho1();

            LerApagar();

            Desenho2();

            LerApagar();

            BemVindo();

            var opcaoDoMenu = MenuDeInicio();

            while (opcaoDoMenu != 6)
            {
                if (opcaoDoMenu == 1)
                {
                    AlocarUmCarro();
                }
                if (opcaoDoMenu == 2)
                {
                    DesalocarUmCarro();
                }
                if (opcaoDoMenu == 3)
                {
                    LerApagar();

                    MostrarListaDeCarros();
                }
                if (opcaoDoMenu == 4)
                {
                    Desenho1();
                }
                if (opcaoDoMenu == 5)
                {
                    Desenho2();
                }
                
                opcaoDoMenu = MenuDeInicio();
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Método para carregar a base de dados
        /// </summary>
        public static void CarregaBaseDeCarros()
        {
            baseDeVeiculos = new string[2, 3]
            {
                {"Lamborghini", "2019", "Sim!"},
                {"Fusca", "1969", "Não!"}
            };
        }

        /// <summary>
        /// Método para mostrar a tela de boas vindas
        /// </summary>
        public static void BemVindo()
        {
            Console.WriteLine("******************************************************************");
            Console.WriteLine("*Bem vindo ao sistema de alocação de veículos VELOZES E FURIOSOS!*");
            Console.WriteLine("*________________________________________________________________*");
            Console.WriteLine("*_____________________GOTTA GO FAST!_____________________________*");
            Console.WriteLine("*________________________________________________________________*");
            Console.WriteLine("******************************************************************");
            /*
            Console.WriteLine("                   __________________                             ");
            Console.WriteLine(@"                  /        |         \                           ");
            Console.WriteLine(@"                 /         |          \                           ");
            Console.WriteLine(@" _______________/__________|___________\_________________         ");
            */
        }

        /// <summary>
        /// Método para mostrar o menu inicial
        /// </summary>
        /// <returns>Retorna a escolha do usuário</returns>
        public static int MenuDeInicio()
        {
            Console.WriteLine("\r\nInicializando o sistema VELOZES E FURIOSOS!");
            Console.WriteLine("Bem vindo ao menu principal!");
            Console.WriteLine("1 - Se você deseja alocar um carro.");
            Console.WriteLine("2 - Se você deseja desalocar um carro.");
            Console.WriteLine("3 - Se você quer ver a listagem de carros.");
            Console.WriteLine("4 - Se você deseja ver o incrível desenho 1.");
            Console.WriteLine("5 - Se você deseja ver o incrível desenho 2.");
            Console.WriteLine("6 - Se você deseja sair do sistema.");
            Console.WriteLine("Digite o número desejado.");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int escolha);

            return escolha;
        }

        /// <summary>
        /// Método para pesquisar o carro para alocação
        /// </summary>
        /// <param name="nomeCarro"></param>
        /// <returns>Retorna verdadeiro se o carro puder ser alocado</returns>
        public static bool PesquisaCarroParaAlocacao(string nomeCarro)
        {
            for (int i = 0; i < baseDeVeiculos.GetLength(0); i++)
            {
                if (nomeCarro == baseDeVeiculos[i, 0])
                {
                    Console.Clear();
                    Console.WriteLine($"O carro: {nomeCarro}" +
                        $" pode ser alocado? {baseDeVeiculos[i, 2]}\r\n");

                    for (int j = 0; j < baseDeVeiculos.GetLength(0); j++)
                    {
                        Console.WriteLine($"Carro: {baseDeVeiculos[j, 0]} Ano: {baseDeVeiculos[j, 1]} Disponível: {baseDeVeiculos[j, 2]}");
                    }
                    return baseDeVeiculos[i, 2] == "Sim!";
                }
            }

            return false;
        }

        /// <summary>
        /// Método para verficiar se o carro pode ser alocado
        /// </summary>
        /// <param name="nomeCarro"></param>
        public static void AtualizarCarro(string nomeCarro, bool alocar)
        {
            for (int i = 0; i < baseDeVeiculos.GetLength(0); i++)
            {
                if (nomeCarro == baseDeVeiculos[i, 0])
                { 
                    baseDeVeiculos[i, 2] = alocar? "Não!": "Sim!";
                }
            }
            Console.Clear();
            Console.WriteLine("Carro atualizado com sucesso!");
        }

        /*
        /// <summary>
        /// Método para mostrar o menu de alocação de carro
        /// </summary>
        public static void MenuAlocacaoDeCarro()
        {
            Console.Clear();

            BemVindo();

            Console.WriteLine("Menu - Alocação dos carros mega velozes e mega furiosos:\r\n");
            Console.WriteLine("Listagem de mega carros:");

            MostrarListaDeCarros();

            Console.WriteLine("\nDigite o nome do carro mega veloz e mega furioso:");

            var nomedocarro = Console.ReadLine();
            
        }
        */

        /// <summary>
        /// Método para mostrar o desenho 1
        /// </summary>
        public static void Desenho1()
        {
            Console.Clear();
            Console.WriteLine(@"§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§
§__________________________________________________________________________§
§___________________________$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$________§
§_________________________$$$$$$$$§§§§§$$$$$$$$$$$$$$$$$$$$$$$$$$$$$_______§
§________________________$____$_$$__§§§§___$$$_________________$$$$$$______§
§_______________________$____$_$__o___§§___$$$__________________$$$$$______§
§______________________$____$___$______$___$$$___________________$$$$______§
§_____________________$___$$____$_$___$____$$$___________________$$$$______§
§____________________$___$$$_____$$$$$_____$$$___________________$$$$$_____§
§_____________$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$_____§
§_______$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$____§
§____$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$____§
§__$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$____§
§_$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$____§
§_$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$____§
§_$$$$$$$$_$$$$$_$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$_$$$$$_$$$$$$$$$$$$$____§
§_$$$$$$$_$_____$_$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$_$_____$_$$$$$$$$$$$$$___§
§$$$$$$$_$_______$_$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$_$_______$_$$$$$$$$$$$$$__§
§$$$$$$_$_________$_$$$$$$$$$$$$$$$$$$$$$$$$$$$$_$_________$_$$$$$$$$$$$$__§
§_$$$$$_$_________$_$$$$$$$$$$$$$$$$$$$$$$$$$$$$_$_________$_$$$$$$$$$$$§§§§
§__$$$$_$_________$_$$$$$$$$$$$$$$$$$$$$$$$$$$$$_$_________$_$$$$$$$$$$§§§§§
§__$$$$__$_______$________________________________$_______$________________§
§_________$_____$__________________________________$_____$_________________§
§__________$$$$$____________________________________$$$$$__________________§
§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§");
        }

        /// <summary>
        /// Método para mostrar o desenho 2
        /// </summary>
        public static void Desenho2()
        {
            Console.Clear();
            Console.WriteLine(@"░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
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
        }

        /// <summary>
        /// Método para ler uma tecla e limpar o console
        /// </summary>
        public static void LerApagar()
        {
            Console.ReadKey();

            Console.Clear();
        }

        public static void AlocarUmCarro()
        {
            MostrarMenuInicialCarros("Alocar um carro:");

            var nomedocarro = Console.ReadLine();
            if (PesquisaCarroParaAlocacao(nomedocarro))
            {
                Console.Clear();
                BemVindo();
                Console.WriteLine("Você deseja alocar o carro? Para sim(1) para não(0)");

                AtualizarCarro(nomedocarro, Console.ReadKey().KeyChar.ToString() == "1");

                MostrarListaDeCarros();

                Console.ReadKey();
            }
        }

        public static void DesalocarUmCarro()
        {
            MostrarMenuInicialCarros("Desalocar um carro:");

            MostrarListaDeCarros();

            var nomedocarro = Console.ReadLine();
            if (!PesquisaCarroParaAlocacao(nomedocarro))
            {
                Console.Clear();
                Console.WriteLine("Você deseja desalocar o carro? Para sim(1) para não(0)");

                AtualizarCarro(nomedocarro, Console.ReadKey().KeyChar.ToString() == "0");

                MostrarListaDeCarros();

                Console.ReadKey();
            }
        }

        public static void MostrarListaDeCarros()
        {
            for (int i = 0; i < baseDeVeiculos.GetLength(0); i++)
            {
                Console.WriteLine($"Carro: {baseDeVeiculos[i, 0]} Ano: {baseDeVeiculos[i, 1]} Disponível: {baseDeVeiculos[i, 2]}");
            }
        }

        public static void MostrarMenuInicialCarros(string operacao)
        {
            Console.Clear();

            BemVindo();

            Console.WriteLine($"Menu - {operacao}");
            Console.WriteLine("Digite o nome do carro para realizar a operação:");
        }
    }
}
