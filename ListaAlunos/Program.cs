using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAlunos
{
    class Program
    {
        static string[,] listaDeAlunos;
        static void Main(string[] args)
        {
            CarregaListaDeAlunos();

            PrintarLista();
        }

        /// <summary>
        /// Método que contém e carrega a lista de alunos
        /// </summary>
        public static void CarregaListaDeAlunos()
        {
            listaDeAlunos = new string[20, 3]
            {
                {"Gabriel","25","Masculino"},
                {"Vitor","23","Masculino"},
                {"Guilherme","24","Masculino"},
                {"Vitória","24","Feminino"},
                {"Natália","29","Feminino"},
                {"Jonathan","30","Masculino"},
                {"Christian","29","Masculino"},
                {"Felipe","28","Masculino"},
                {"Ana","31","Feminino"},
                {"Thais","20","Feminino"},
                {"Nicholas","19","Masculino"},
                {"Carol","24","Feminino"},
                {"Vilson","35","Masculino"},
                {"Nicholas","21","Masculino"},
                {"Paco","25","Masculino"},
                {"Billy","23","Masculino"},
                {"Fernanda","22","Feminino"},
                {"Maria","21","Feminino"},
                {"Aline","26","Feminino"},
                {"Amanda","28","Feminino"}

            };
        }

        /// <summary>
        /// Método para imprimir no console o nome, idade e sexo de cada aluno.
        /// </summary>
        public static void PrintarLista()
        {
            for (int i = 0; i < listaDeAlunos.GetLength(0); i++)
            {
                Console.WriteLine($"\nO nome d@ alun@ é: {listaDeAlunos[i,0]}" +
                          $"\nA idade d@ alun@ é: {listaDeAlunos[i,1]}" +
                          $"\nO sexo d@ alu@ é: {listaDeAlunos[i,2]}");
            }

            Console.ReadKey();
        }
    }
}
