using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitaDeBolo
{
    class Program
    {

        static void Main(string[] args)
        {
            BemVindo();

            ReceitaBolo();
        }

        /// <summary>
        /// Método que contém a lista com os passos da receita de bolo
        /// </summary>
        public static void ReceitaBolo()
        {
            string[] receita = new string[8] {@"
                                        ──────▄▀▄─────▄▀▄
                                        ─────▄█░░▀▀▀▀▀░░█▄
                                        ─▄▄──█░░░░░░░░░░░█──▄▄
                                        █▄▄█─█░░▀░░┬░░▀░░█─█▄▄█
                               BEM VINDO A SUA RECEITA DE BOLO DELICIOSA!",
                                               @"
                                        ──────▄▀▄─────▄▀▄
                                        ─────▄█░░▀▀▀▀▀░░█▄
                                        ─▄▄──█░░░░░░░░░░░█──▄▄
                                        █▄▄█─█░░▀░░┬░░▀░░█─█▄▄█
                                            INGREDIENTES
                                    -> 2 xícaras (chá) de açucar
                                    -> 3 xícaras (chá) de farinha de trigo
                                    -> 4 colheres (sopa) de margarina
                                    -> 3 ovos
                                    -> 1 e 1/2 xícara (chá) de leite
                                    -> 1 colher (sopa) bem cheia de fermento em pó",
                                               @"
                                        ──────▄▀▄─────▄▀▄
                                        ─────▄█░░▀▀▀▀▀░░█▄
                                        ─▄▄──█░░░░░░░░░░░█──▄▄
                                        █▄▄█─█░░▀░░┬░░▀░░█─█▄▄█
                                           MODO DE PREPARO
                                 1- Bata as claras em neve e reserve.",
                                               @"
                                        ──────▄▀▄─────▄▀▄
                                        ─────▄█░░▀▀▀▀▀░░█▄
                                        ─▄▄──█░░░░░░░░░░░█──▄▄
                                        █▄▄█─█░░▀░░┬░░▀░░█─█▄▄█
                                           MODO DE PREPARO
               2- Misture as gemas, a margarina e o açúcar até obter uma massa homogênea.",
                                               @"
                                        ──────▄▀▄─────▄▀▄
                                        ─────▄█░░▀▀▀▀▀░░█▄
                                        ─▄▄──█░░░░░░░░░░░█──▄▄
                                        █▄▄█─█░░▀░░┬░░▀░░█─█▄▄█
                                           MODO DE PREPARO
                3- Acrescente o leite e a farinha de trigo aos poucos, sem parar de bater.",
                                               @"
                                        ──────▄▀▄─────▄▀▄
                                        ─────▄█░░▀▀▀▀▀░░█▄
                                        ─▄▄──█░░░░░░░░░░░█──▄▄
                                        █▄▄█─█░░▀░░┬░░▀░░█─█▄▄█
                                           MODO DE PREPARO
                        4- Por último, adicione as claras em neve e o fermento.",
                                               @"
                                        ──────▄▀▄─────▄▀▄
                                        ─────▄█░░▀▀▀▀▀░░█▄
                                        ─▄▄──█░░░░░░░░░░░█──▄▄
                                        █▄▄█─█░░▀░░┬░░▀░░█─█▄▄█
                                           MODO DE PREPARO
              5- Despeje a massa em uma forma grande de furo central untada e enfarinhada.",
                                               @"
                                        ──────▄▀▄─────▄▀▄
                                        ─────▄█░░▀▀▀▀▀░░█▄
                                        ─▄▄──█░░░░░░░░░░░█──▄▄
                                        █▄▄█─█░░▀░░┬░░▀░░█─█▄▄█
                                           MODO DE PREPARO
                    6- Asse em forno médio 180 °C, preaquecido, por aproximadamente 40 minutos
                                ou ao furar o bolo com um garfo, este saia limpo."};
            for (int i = 0; i < receita.Length; i++)
            {
                Console.Clear();
                Console.WriteLine($"{receita[i]}");
                Console.WriteLine("\r\nAperte qualquer tecla para prosseguir.");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Método que mostra uma tela de bem vindo para o usuário
        /// </summary>
        public static void BemVindo()
        {
            Console.WriteLine(@"
                                ▒▒▒▒▒▒▒█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
                                ▒▒▒▒▒▒▒█░▒▒▒▒▒▒▒▓▒▒▓▒▒▒▒▒▒▒░█
                                ▒▒▒▒▒▒▒█░▒▒▓▒▒▒▒▒▒▒▒▒▄▄▒▓▒▒░█░▄▄
                                ▒▒▄▀▀▄▄█░▒▒▒▒▒▒▓▒▒▒▒█░░▀▄▄▄▄▄▀░░█
                                ▒▒█░░░░█░▒▒▒▒▒▒▒▒▒▒▒█░░░░░░░░░░░█
                                ▒▒▒▀▀▄▄█░▒▒▒▒▓▒▒▒▓▒█░░░█▒░░░░█▒░░█
                                ▒▒▒▒▒▒▒█░▒▓▒▒▒▒▓▒▒▒█░░░░░░░▀░░░░░█
                                ▒▒▒▒▒▄▄█░▒▒▒▓▒▒▒▒▒▒▒█░░█▄▄█▄▄█░░█
                                ▒▒▒▒█░░░█▄▄▄▄▄▄▄▄▄▄█░█▄▄▄▄▄▄▄▄▄█
                                ▒▒▒▒█▄▄█░░█▄▄█░░░░░░█▄▄█░░█▄▄█");
            Console.WriteLine("                             Bem vindo a sua própria receita de bolo!    ");
            Console.WriteLine("                            É o melhor bolo do planeta feito de miojo!   ");
            Console.WriteLine("                          Pressione qualquer tecla para avançar a lista. ");
            Console.ReadKey();
        }
    }
}
