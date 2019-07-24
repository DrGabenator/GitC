using CriandoUmaLista.BibliotecaLista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoUmaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaIni = new ListaIni();

            listaIni.MostrarLista();

            listaIni.VarrerLista();

            listaIni.LimparLista();

            listaIni.VarrerLista();

            listaIni.MudarTamanho(50);

            listaIni.MostrarLista();

            listaIni.VarrerLista();
        }
    }
}
