using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoUmaLista.BibliotecaLista
{

    class ListaIni
    {
        string[] listaIni;

        public ListaIni()
        {
            listaIni = new string[10];
        }

        public void MudarTamanho(int novoTamanho)
        {
            listaIni = new string[novoTamanho];
        }

        public void MostrarLista()
        {
            //laço que usamos geralmente para andar sobre as posições da nossa lista
            for (int i = 0; i < listaIni.Length; i++)
            {
                //carregando os valores da nossa lista aqui 
                //aonde "i" representa cada espaço que temos disponivel
                listaIni[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");
                //DateTime e um tipo do .net c# que disponibiliza funções relacionadas a datas
                //e horas, ou seja se precisar trabalhar com essas informações é possivel usar esse cara.
            }

        }

        public void VarrerLista()
        {
            //Laço de repetição que usamos para varrer nossa lista de maneira mais simples
            foreach (var item in listaIni)//"var item" indica uma unidade da nossa lista "in lista" 
                //indica a lista que desejamos varrer
                Console.WriteLine(item);//Aqui apresentamos essa informação na tela

            Console.ReadKey();
        }

        public void LimparLista()
        {
            for (int i = 0; i < listaIni.Length; i++)
            {
                listaIni[i] = string.Empty;//Aqui limpamos o nosso valor dentro da coleção
            }
        }

    }
}
