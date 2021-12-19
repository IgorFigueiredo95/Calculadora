using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
     public static class Calculadora
    {
         public static double Soma(double a, double b)
        {

            double resultado = a + b;
            return resultado;
        }
        public static double Subtracao(double a, double b)
        {

            double resultado = a - b;
            return resultado;
        }
        public static double Multiplicacao(double a, double b)
        {

            double resultado = a * b;
            return resultado;
        }
        public static double Divisao(double a, double b)
        {

            double resultado = a / b;
            return resultado;
        }
    }
}
