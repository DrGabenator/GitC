using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeLista
{
    class Program
    {
        static void Main(string[] args)
        {
            //Iniciando uma lista de string com array linear
            string[] lista = new string[10];//Aqui definimos as posições da lista iniciando ela com 10 espaços na memória para alocar informações de texto

            //Laço que usamos geralmente para andar sobre as posições da nossa lista
            for (int i = 0; i < lista.Length; i++)
            {
                //Carregando os valores da nossa lista aqui
                //Aonde "i" representa cada espaço que temos disponível
                lista[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");
                //DateTime é um tipo do .net C# que disponibiliza funções relacionadas a datas e horas, ou seja, 
                //se precisar trabalhar com essas informações é possível trabalhar com esse cara
            }

            //Laço de repetição que usamos para varrer nossa lista de maneira mais simples
            foreach (var item in lista) //"var item" indica uma unidade da nossa lista "in lista"
                //indica a lista que desejamos varrer
                Console.WriteLine(item);//Aqui apresentamos essa informação na tela

            Console.ReadKey();

            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = string.Empty;//Aqui limpamos o nosso valor dentro da coleção
            }

            //Laço de repetição que usamos para varrer nossa lista de maneira mais simples
            foreach (var item in lista) //"var item" indica uma unidade da nossa lista "in lista"
                //indica a lista que desejamos varrer
                Console.WriteLine(item);//Aqui apresentamos essa informação na tela

            Console.ReadKey();
        }
    }
}
