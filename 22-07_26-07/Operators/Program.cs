using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var elementoX = new Teste(5,5);

            elementoX.MostrarInformacoes();

            elementoX.AlteraInformacoes(5,5);

            elementoX.MostrarInformacoes();

            elementoX.AlteraInformacoes();

            elementoX.MostrarInformacoes();

            Console.ReadKey();
        }

    }

    public class Teste
    {
        public int A { get; set; } = 0;
        public int B { get; set; } = 0;
        public Teste(int pA, int pB)
        {
            A = pA;
            B = pB;
        }

        public void AlteraInformacoes()
        {
            A = B * 100;
        }


        public void AlteraInformacoes(int pA, int pB)
        {
            A = pA * 2;
            B = pB * 2;
        }

        public void MostrarInformacoes()
        {
            Console.WriteLine(A + B);
        }
    }
        
}
