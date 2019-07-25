using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCalculadora.Operacoes
{
    public class Calc
    {
        public Calc()
        {
            Console.WriteLine("Digite o número da operação desejada:");
            Console.WriteLine("1 - SOMA");
            Console.WriteLine("2 - SUBTRAÇÃO");
            Console.WriteLine("3 - MULTIPLICAÇÃO");
            Console.WriteLine("4 - DIVISÃO\n");
            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":

                    Soma();

                    break;
                case "2":

                    Subtracao();

                    break;
                case "3":

                    Multiplicacao();

                    break;
                case "4":

                    Divisao();

                    break;
            }
        }

        public void Soma()
        {
            Console.WriteLine("Digite o primeiro operador: ");
            double.TryParse(Console.ReadLine(), out double op1);

            Console.WriteLine("Digite segundo operador: ");
            double.TryParse(Console.ReadLine(), out double op2);

            double resultSomar = op1 + op2;

            Console.WriteLine($"O resultado da soma de {op1} com {op2} é {resultSomar}");
        }

        public void Subtracao()
        {
            Console.WriteLine("Digite o primeiro operador: ");
            double.TryParse(Console.ReadLine(), out double op1);

            Console.WriteLine("Digite segundo operador: ");
            double.TryParse(Console.ReadLine(), out double op2);

            double resultSub = op1 - op2;

            Console.WriteLine($"O resultado da subtração de {op1} com {op2} é {resultSub}");
        }

        public void Multiplicacao()
        {
            Console.WriteLine("Digite o primeiro operador: ");
            double.TryParse(Console.ReadLine(), out double op1);

            Console.WriteLine("Digite segundo operador: ");
            double.TryParse(Console.ReadLine(), out double op2);

            double resultMult = op1 * op2;
            Console.WriteLine($"O resultado da multiplicação de {op1} com {op2} é {resultMult}");
        }

        public void Divisao()
        {
            Console.WriteLine("Digite o primeiro operador: ");
            double.TryParse(Console.ReadLine(), out double op1);

            Console.WriteLine("Digite segundo operador: ");
            double.TryParse(Console.ReadLine(), out double op2);

            double resultDiv = op1 / op2;

            Console.WriteLine($"O resultado da divisão de {op1} com {op2} é {resultDiv}");
        }

    }
}
