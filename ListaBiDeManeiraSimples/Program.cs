using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiDeManeiraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando nossa lista bi dimensional
            string[,] listaDeNome = new string[5, 2];

            //Usando um laço simples para colocar valores mas no mesmo agora utilizando o GetLength com o parametro "0"
            //para indicar que queremos o tamanho da primeira coluna
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                //Carregando o que podemos chamar de ID, indentificador do nosso registro único
                listaDeNome[i, 0] = i.ToString();
                //Aqui apenas adicionamos uma informação extra para deixar legal
                listaDeNome[i, 1] = $"Gabriel_{i}";
            }

            //Lembrando que GetLength é um método e usamos "(parametro)" com parametro ou as vezes sem para realizar a chamada do mesmo
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                //Formatamos uma string de maneira que os dados sejam apresentados
                Console.WriteLine($"ID:{listaDeNome[i,0]} - Nome:{listaDeNome[i,1]}");
            }

            Console.ReadKey();
        }
    }
}
