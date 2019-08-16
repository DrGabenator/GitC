using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioDeEscola.BibliotecaEscolar
{
    public class BiblioAluno
    {
        string[,] aluno = new string[5, 5];
        readonly BiblioEscola biblioteca = new BiblioEscola();

        /// <summary>
        /// Método para mostrar os menu
        /// </summary>
        public void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("-----------Bem vindo ao sistema escolar-----------");
            Console.WriteLine("Digite o número da operação desejada:");
            Console.WriteLine("1 - Cadastrar 5 alunos com suas notas e frequências");
            Console.WriteLine("2 - Listar os alunos cadastrados");
            Console.WriteLine("3 - Excluir o registro de um aluno");
            Console.WriteLine("4 - Alterar notas de um aluno");
            Console.WriteLine("4 - Para sair do sistema\n");

        }

        /// <summary>
        /// Método para cadastrar alunos
        /// </summary>
        public void CadastrarAluno()
        {

            for (int i = 0; i < aluno.GetLength(0); i++)
            {
                Console.Clear();
                Console.WriteLine("-----------Bem vindo ao sistema de cadastro escolar-----------");

                aluno[i, 0] = i.ToString();

                Console.WriteLine($"Digite o nome do aluno {i + 1}: ");
                var nome = Console.ReadLine();
                aluno[i, 1] = nome;

                Console.WriteLine("Digite a primeira nota do aluno: ");
                float.TryParse(Console.ReadLine(), out float nota1);

                Console.WriteLine("Digite a segunda nota do aluno: ");
                float.TryParse(Console.ReadLine(), out float nota2);

                Console.WriteLine("Digite a terceira nota do aluno: ");
                float.TryParse(Console.ReadLine(), out float nota3);

                var media = biblioteca.Media(nota1, nota2, nota3);
                aluno[i, 2] = media.ToString();

                Console.WriteLine("Informe o total de aulas: ");
                int.TryParse(Console.ReadLine(), out int totAulas);

                Console.WriteLine("Informe o total de faltas: ");
                int.TryParse(Console.ReadLine(), out int faltas);

                var frequencia = biblioteca.Frequencia(totAulas, faltas);
                aluno[i, 3] = frequencia.ToString();

                var situacao = biblioteca.RetornaSituacao(media, frequencia);
                aluno[i, 4] = situacao.ToString();

                Console.Clear();
            }
        }

        /// <summary>
        /// Método para listar os alunos e todas as informações
        /// </summary>
        public void ListarAluno()
        {
            Console.Clear();

            for (int i = 0; i < aluno.GetLength(0); i++)
            {
                Console.WriteLine($"Nome do aluno: {aluno[i, 1]}, " +
                    $"Média do aluno: {aluno[i, 2]}, " +
                    $"Frequência do aluno: {aluno[i, 3]}%, " +
                    $"Situação do aluno: {aluno[i, 4]}");
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Método para deletar um registro da lista
        /// </summary>
        public void DeletarRegistro()
        {
            Console.Clear();
            for (int i = 0; i < aluno.GetLength(0); i++)
                Console.WriteLine($"ID do aluno: {aluno[i, 0]} " + $"Nome do aluno: {aluno[i, 1]}");

            Console.WriteLine("Digite o número do ID do aluno para deletar o registro");
            var id = Console.ReadLine().ToString();
            for (int i = 0; i < aluno.GetLength(0); i++)
            {
                if (id == aluno[i, 0])
                {
                    for (int j = 0; j < aluno.GetLength(1); j++)
                    {
                        aluno[i, j] = string.Empty;
                    }
                }
            }
        }

        /// <summary>
        /// Método para alterar as notas de acordo com o ID
        /// </summary>
        public void AlterarNotas()
        {
            Console.Clear();
            for (int i = 0; i < aluno.GetLength(0); i++)
                Console.WriteLine($"ID do aluno: {aluno[i, 0]} " + $"Nome do aluno: {aluno[i, 1]}");

            Console.WriteLine("Digite o número do ID do aluno para inserir suas notas novamente");
            var id = Console.ReadLine().ToString();
            for (int i = 0; i < aluno.GetLength(0); i++)
            {
                if (id == aluno[i, 0])
                {
                    Console.WriteLine("Digite a primeira nota do aluno: ");
                    float.TryParse(Console.ReadLine(), out float nota1);

                    Console.WriteLine("Digite a segunda nota do aluno: ");
                    float.TryParse(Console.ReadLine(), out float nota2);

                    Console.WriteLine("Digite a terceira nota do aluno: ");
                    float.TryParse(Console.ReadLine(), out float nota3);

                    var media = biblioteca.Media(nota1, nota2, nota3);
                    aluno[i, 2] = media.ToString();
                }
            }
        }
    }
}
