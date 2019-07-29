using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MostrarJoinhaClass;

namespace UsandoBibliotecaJoinha
{
    class Program
    {
        static void Main(string[] args)
        {
            /*new AquiMostraJoinha().MetodoInicialDoJoinha();

            new AquiMostraJoinha().MetodoDoisPontoZero(true);

            new AquiMostraJoinha().MetodoDoisPontoZero(false);*/

            var outroCaraParaRealizarOTeste = new AquiMostraJoinha().TesteUmOperadorLegal();

            var tamamanhoDaLista = outroCaraParaRealizarOTeste.Length;

            for (int i = 0; i < tamamanhoDaLista; i++)
            {
                Console.WriteLine(outroCaraParaRealizarOTeste[i]);
            }

            Console.ReadKey();
        }
    }
}
