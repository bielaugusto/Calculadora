using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class CalculadoraCientifica : CalculadoraPadrao
    {
        public double Seno(double valor)
        {
            return Math.Sin(valor);
        }

        public double Cosseno(double valor)
        {
            return Math.Cos(valor);
        }

        public double Tangente(double valor)
        {
            return Math.Tan(valor);
        }

        public double Logaritmo(double valor)
        {
            return Math.Log(valor);
        }
    }
}
