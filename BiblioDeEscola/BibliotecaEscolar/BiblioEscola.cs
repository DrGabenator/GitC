using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioDeEscola.BibliotecaEscolar
{
    public class BiblioEscola
    {
        public float Media(float nota1, float nota2, float nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }

        public int Frequencia(int totAulas, int faltas)
        {
            return ((totAulas - faltas) * 100) / totAulas;
        }

        public void Situacao(float Media, float Frequencia)
        {
            if (Media >= 7)
                Console.WriteLine($"O aluno está aprovado com média {Media}");
            else
                Console.WriteLine($"O aluno está está reprovado com média {Media}");

            if (Frequencia >= 75)
                Console.WriteLine($"O aluno obteve frequência maior que 75%. Frequência de {Frequencia}%");
            else
                Console.WriteLine($"O aluno não obteve frequência maior que 75% e está reprovado por frequência. Frequência de {Frequencia}%");

            if (Media >= 7 && Frequencia >= 75)
                Console.WriteLine($"O aluno está aprovado por média e frequência. Média de {Media} frequência de {Frequencia}%");
            else
                Console.WriteLine($"O aluno está reprovado por média ou frequência. Média de {Media} frequência de {Frequencia}%");
        }

        public string RetornaSituacao(float Media, float Frequencia)
        {
            if (Media >= 7 && Frequencia >= 75)
            {
                return "Aprovado";
            }
            return "Reprovado";
        }

    }
}
