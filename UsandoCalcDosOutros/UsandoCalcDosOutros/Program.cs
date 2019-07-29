using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calc;

namespace UsandoCalcDosOutros
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o número da operação desejada:");
            Console.WriteLine("1 - SOMA");
            Console.WriteLine("2 - SUBTRAÇÃO");
            Console.WriteLine("3 - MULTIPLICAÇÃO");
            Console.WriteLine("4 - DIVISÃO");
            Console.WriteLine("5 - ÁREA RETÂNGULO");
            Console.WriteLine("6 - ÁREA TRIÂNGULO EQUILÁTERO");
            Console.WriteLine("7 - RAIO DO CÍRCULO\n");
            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Digite o primeiro operador: ");
                    float.TryParse(Console.ReadLine(), out float op1Som);
                    Console.WriteLine("Digite o segundo operador: ");
                    float.TryParse(Console.ReadLine(), out float op2Som);
                    Console.WriteLine(new Operacoes().CalculaAdicao(op1Som, op2Som));

                    break;
                case "2":
                    Console.WriteLine("Digite o primeiro operador: ");
                    float.TryParse(Console.ReadLine(), out float op1Sub);
                    Console.WriteLine("Digite o segundo operador: ");
                    float.TryParse(Console.ReadLine(), out float op2Sub);
                    Console.WriteLine(new Operacoes().CalculaSubtracao(op1Sub, op2Sub));

                    break;
                case "3":
                    Console.WriteLine("Digite o primeiro operador: ");
                    float.TryParse(Console.ReadLine(), out float op1Mul);
                    Console.WriteLine("Digite o segundo operador: ");
                    float.TryParse(Console.ReadLine(), out float op2Mul);
                    Console.WriteLine(new Operacoes().CalculaMultiplicacao(op1Mul, op2Mul));

                    break;
                case "4":
                    Console.WriteLine("Digite o primeiro operador: ");
                    float.TryParse(Console.ReadLine(), out float op1Div);
                    Console.WriteLine("Digite o segundo operador: ");
                    float.TryParse(Console.ReadLine(), out float op2Div);
                    Console.WriteLine(new Operacoes().CalculaDivisao(op1Div, op2Div));

                    break;

                case "5":
                    Console.WriteLine("Digite a base do retângulo: ");
                    float.TryParse(Console.ReadLine(), out float bsRet);
                    Console.WriteLine("Digite a altura do retângulo: ");
                    float.TryParse(Console.ReadLine(), out float alturaRet);
                    Console.WriteLine(new Operacoes().CalculaRet(bsRet, alturaRet));

                    break;

                case "6":
                    Console.WriteLine("Digite a base do triângulo: ");
                    float.TryParse(Console.ReadLine(), out float bsTri);
                    Console.WriteLine("Digite a altura do triângulo: ");
                    float.TryParse(Console.ReadLine(), out float alturaTri);
                    Console.WriteLine(new Operacoes().CalculaTriEq(bsTri, alturaTri));

                    break;

                case "7":
                    Console.WriteLine("Digite a área do círculo para receber o raio: ");
                    float.TryParse(Console.ReadLine(), out float area);
                    Console.WriteLine(new Operacoes().CalculaRaio(area));

                    break;
            }
            Console.ReadKey();
        }
    }
}
