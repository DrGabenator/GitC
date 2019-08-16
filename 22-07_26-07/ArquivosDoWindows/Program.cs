using BibliotecaDeArquivosDoWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquivosDoWindows
{
    class Program
    {
        static void Main(string[] args)
        {
            var arquivos = new GetFiles();

            Console.WriteLine("Arquivos contidos na pasta Meus Documentos:");
            foreach (var item in arquivos.RetornaArquivosDoMeuDocumentos())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            Console.WriteLine("\nArquivos contidos na pasta Minhas Imagens:");
            foreach (var item in arquivos.RetornaArquivosImagesFiles())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            Console.WriteLine("\nArquivos contidos na pasta GitC:");
            foreach (var item in arquivos.RetornaArquivosGit())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
