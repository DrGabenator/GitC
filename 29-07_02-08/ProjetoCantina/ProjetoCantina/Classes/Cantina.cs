using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCantina.Classes
{

    public class Cantina
    {
        double saldo = 0;

        public Cantina()
        {
            saldo = 20;
        }

        public bool Comprar(double valor)
        {
            if (valor <= saldo)
            {
                //Desconta do valor em saldo na conta
                saldo -= valor;
                return true;
            }
            //Retorna false em caso de não conter saldo disponível
            return false;
        }

        public double MostrarSaldo()
        {
            return saldo;
        }
    }
}
