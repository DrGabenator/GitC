using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioCalc
{
    public class Calculadora
    {
        public float Soma(float op1Som, float op2Som)
        {
            return op1Som + op2Som;
        }

        public float Subtracao(float op1Sub, float op2Sub)
        {
            return op1Sub - op2Sub;
        }

        public float Multiplicacao(float op1Mul, float op2Mul)
        {
            return op1Mul * op2Mul;
        }

        public float Divisao(float op1Div, float op2Div)
        {
            return op1Div / op2Div;
        }

        public float AreaRetangulo(float bsRet, float alturaRet)
        {
            return bsRet * alturaRet;
        }

        public float AreaTrianguloEquilatero(float bsTri, float alturaTri)
        {
            return (bsTri * alturaTri) / 2;
        }

        public double AreaCirculo(double area)
        {
            return Math.Sqrt(area / Math.PI);
        }
    }
}
