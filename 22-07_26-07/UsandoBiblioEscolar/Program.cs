using BiblioDeEscola.BibliotecaEscolar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoBiblioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            BiblioAluno biblioAluno = new BiblioAluno();

            while (true)
            {
                biblioAluno.MostrarMenu();

                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        biblioAluno.CadastrarAluno();
                        break;
                    case "2":
                        biblioAluno.ListarAluno();
                        break;
                    case "3":
                        biblioAluno.DeletarRegistro();
                        break;
                    case "4":
                        biblioAluno.AlterarNotas();
                        break;
                   
                    case "5":
                        return;
                }
            }
        }
    }
}
