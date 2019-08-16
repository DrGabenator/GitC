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

            //Aqui como estamos usando apenas uma referência da nossa lista colocamos ref ao passar ela no método
            CarregaInformacoesEListaElasEmTela(ref listaDeNome);

            //Após carregas as informações e mostrar em tela ele espera um comando
            Console.ReadKey();

            //Indicamos que o usuário precisa informar um número de identificação para pesquisar um registro.
            Console.WriteLine("Informe o ID do registro a ser pesquisado.");

            //Aqui como realizamos uma pesquisa somente na chamada
            //Passamos a nossa lista normalmente pois não iremos alterar e apenas pesquisar a informação
            //Após a vírgula temos o console readline que espera nosso identificador único
            PesquisandoInformacoesNaNossaLista(listaDeNome, Console.ReadLine());

            Console.ReadKey();
        }

        /// <summary>
        /// Método que carrega as informações dentro da nossa lista criada no metodo "MAIN"
        /// E mostra as informações logo em seguida
        /// </summary>
        /// <param name="arrayBi">Nossa lista a ser carregada.</param>
        public static void CarregaInformacoesEListaElasEmTela(ref string[,] arrayBi)
        {
            
            //Usando um laço simples para colocar valores mas no mesmo agora utilizando o GetLength com o parametro "0"
            //para indicar que queremos o tamanho da primeira coluna
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Carregando o que podemos chamar de ID, indentificador do nosso registro único
                arrayBi[i, 0] = i.ToString();
                //Aqui apenas adicionamos uma informação extra para deixar legal
                arrayBi[i, 1] = $"Gabriel_{i}";
            }

            //Lembrando que GetLength é um método e usamos "(parametro)" com parametro ou as vezes sem para realizar a chamada do mesmo
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Formatamos uma string de maneira que os dados sejam apresentados
                Console.WriteLine($"ID:{arrayBi[i, 0]} - Nome:{arrayBi[i, 1]}");
            }

        }
        
        /// <summary>
        /// Método que realiza a pesquisa pelo identificador único de nossa coleção
        /// </summary>
        /// <param name="arrayBi">Nossa coleção de informações</param>
        /// <param name="pId">Nosso identificador único</param>
        public static void PesquisandoInformacoesNaNossaLista(string[,] arrayBi, string pId)
        {
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Realizamos nossa comparação dos mesmos tipos
                if (arrayBi[i, 0] == pId)
                {
                    //Mostramos as informações formatadas da nossa pesquisa
                    Console.WriteLine($"Informaçaõ escolhida: ID:{arrayBi[i, 0]} - Nome{arrayBi[i, 1]}");

                    //Aqui saimos da nossa lista mas retornamos vazio "return;" pois estamos em um metodo vazio "void" que não espera retornar algo
                    return;
                }
            }

            //Caso ele passe por esta linha identificamos que ele não encontrou resultado compatíveis.
            Console.WriteLine("Infelizmente a busca pelo ID não resultou em nenhuma informação.");
        }
    }
}
