using ProjetoCantina.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCantina
{
    class Program
    {
        static void Main(string[] args)
        {
            Cantina alunoConta = new Cantina();

            while (true)
            {
                Console.WriteLine("------BEM VINDO AO SISTEMA DE CANTINA GG------");
                Console.WriteLine("Digite o número do lanche a ser comprado: ");
                Console.WriteLine("1 - Pão de queijo R$2,00");
                Console.WriteLine("2 - Misto quente R$5,00");
                Console.WriteLine("3 - Espetinho de óleo com carne R$8,00");
                Console.WriteLine("4 - Mega hambúrguer triplo stacker com infarto R$15,00");
                Console.WriteLine("5 - Comprar o resto em bala");
                Console.WriteLine("6 - Para ver o seu saldo");

                var escolha = Console.ReadLine();
                switch (escolha)
                {
                    case "1":
                        if (alunoConta.MostrarSaldo() > 1)
                        {
                            alunoConta.Comprar(2.00);
                            Console.WriteLine("Compra realizada com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Você não possui saldo suficiente.");
                        }
                        break;
                    case "2":
                        if (alunoConta.MostrarSaldo() > 4)
                        {
                            alunoConta.Comprar(5.00);
                            Console.WriteLine("Compra realizada com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Você não possui saldo suficiente.");
                        }
                        break;
                    case "3":
                        if (alunoConta.MostrarSaldo() > 7)
                        {
                            alunoConta.Comprar(8.00);
                            Console.WriteLine("Compra realizada com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Você não possui saldo suficiente.");

                        }
                            break;
                    case "4":
                        if (alunoConta.MostrarSaldo() > 14)
                        {
                            alunoConta.Comprar(15.00);
                            Console.WriteLine("Compra realizada com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Você não possui saldo suficiente.");
                        }
                        break;
                    case "5":
                        Console.WriteLine($"Você possui R${alunoConta.MostrarSaldo()}");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
