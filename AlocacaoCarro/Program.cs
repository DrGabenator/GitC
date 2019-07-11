﻿using System;
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

            if (MenuDeInicio() == 1)
            {
                MenuAlocacaoDeCarro();
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
            Console.WriteLine("Você deseja alocar um carro MEGA VELOZ E MEGA FURIOSO?");
            Console.WriteLine("1 - Sim!");
            Console.WriteLine("2 - Não!(TEM CERTEZA QUE NÃO QUER!?)");
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
                    Console.WriteLine($"O carro: {nomeCarro}" +
                        $" pode ser alocado? {baseDeVeiculos[i, 2]}");

                    return baseDeVeiculos[i, 2] == "Sim!";
                }
            }

            return false;
        }

        /// <summary>
        /// Método para verficiar se o carro pode ser alocado
        /// </summary>
        /// <param name="nomeCarro"></param>
        public static void AlocarCarro(string nomeCarro)
        {
            for (int i = 0; i < baseDeVeiculos.GetLength(0); i++)
            {
                if (nomeCarro == baseDeVeiculos[i, 0])
                    baseDeVeiculos[i, 2] = "Não!";
            }
        }

        /// <summary>
        /// Método para mostrar o menu de alocação de carro
        /// </summary>
        public static void MenuAlocacaoDeCarro()
        {
            Console.Clear();

            BemVindo();

            Console.WriteLine("Menu - Alocação dos carros mega velozes e mega furiosos:\r\n");
            Console.WriteLine("Listagem de mega carros:");
            for (int i = 0; i < baseDeVeiculos.GetLength(0); i++)
            {
                Console.WriteLine($"Carro: {baseDeVeiculos[i, 0]} Ano: {baseDeVeiculos[i, 1]} Disponível: {baseDeVeiculos[i, 2]}");
            }
            Console.WriteLine("\nDigite o nome do carro mega veloz e mega furioso:");

            var nomedocarro = Console.ReadLine();
            if (PesquisaCarroParaAlocacao(nomedocarro))
            {
                Console.Clear();
                Console.WriteLine("Você deseja alocar o mega carro? Para sim(1) para não(0)");
                if (Console.ReadKey().KeyChar.ToString() == "1")
                {
                    AlocarCarro(nomedocarro);
                    Console.Clear();
                    Console.WriteLine("O carro foi alocado com sucesso!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("O carro não pode ser alocado!");
                }
                Console.WriteLine("Listagem de mega carros:");
                for (int i = 0; i < baseDeVeiculos.GetLength(0); i++)
                {
                    Console.WriteLine($"Carro: {baseDeVeiculos[i, 0]} Ano: {baseDeVeiculos[i,1]} Disponível: {baseDeVeiculos[i, 2]}");
                }
            }
        }

        /// <summary>
        /// Método para mostrar o desenho 1
        /// </summary>
        public static void Desenho1()
        {
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
    }
}