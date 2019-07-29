using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TudoEstacionamento.BiblioEstacionamento
{

    public class Carro
    {
        string[,] carroinfo = new string[5, 4];

        public void RegistrarCarro()
        {
            for (int i = 0; i < carroinfo.GetLength(0); i++)
            {
                Console.Clear();
                Console.WriteLine("-----------Bem vindo ao sistema de estacionamento-----------");

                Console.WriteLine($"Digite o modelo do carro {i + 1}: ");
                var nome = Console.ReadLine();
                carroinfo[i, 0] = nome;

                Console.WriteLine($"Digite a placa do carro {i + 1}: ");
                var placa = Console.ReadLine();
                carroinfo[i, 1] = placa.ToString();

                var dataEntrada = System.DateTime.Now.ToString();
                carroinfo[i, 2] = dataEntrada;

                Console.Clear();
            }
        }

        public void AumentarLista()
        {
            //Verifica se precisa criar uma lista maior
            var limiteDaLista = true;

            //Laço que verifica se existe registro disponível
            for (int i = 0; i < carroinfo.GetLength(0); i++)
            {
                //Caso ainda existir registro disponível ele seta nossa variável "limiteDaLista" para false
                if (carroinfo[i, 0] == null)
                {
                    limiteDaLista = false;
                }
            }

            //Caso não tenha mais registro nossa variável ficou como true então indica que precisamos aumentar nossa lista
            if (limiteDaLista)
            {
                var listaCopia = carroinfo;

                carroinfo = new string[carroinfo.GetLength(0) + 5, 4];

                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    carroinfo[i, 0] = listaCopia[i, 0];

                    carroinfo[i, 1] = listaCopia[i, 1];

                    carroinfo[i, 2] = listaCopia[i, 2];

                    carroinfo[i, 3] = listaCopia[i, 3];
                }

                Console.WriteLine("O tamanho da lista foi atualizado.");
            }
        }
    }

}
