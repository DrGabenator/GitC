using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCeSharp.Classes
{
    public class Conta
    {
        double saldo = 0;

        //Propriedade que contem o valor do saldo
        public double Saldo { get { return saldo; } }

        public Conta()
        {
            //Bônus de mil reais para iniciar operação daytrade
            saldo = 1000;
        }

        /// <summary>
        /// Método para sacar de com saldo disponível na conta
        /// </summary>
        /// <param name="valor">Valor para sacar</param>
        /// <returns>Retorna se o saque foi feito ou nãp</returns>
        public bool Sacar(double valor)
        {
            if(valor <= saldo)
            {
                //Desconta do valor em saldo na conta
                saldo -= valor;
                return true;
            }
            //Retorna false em caso de não conter saldo disponível
            return false;
        }

        /// <summary>
        /// Método para mostrar o saldo disponível em conta
        /// </summary>
        public double MostrarSaldo()
        {
            return saldo;
        }
    }
}
