using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias
{
    public class Operaciones
    {

        #region TiposOperaciones
        public double Sumar(double numero1, double numero2)
        {
            var Resultado = numero1 + numero2;

            return Resultado;
        }

        public double Resta(double numero1, double numero2)
        {
            var Resultado = numero1 - numero2;
            return Resultado;
        }

        public double Division(double numero1, double numero2)
        {
            if (numero2 == 0)
            {
                return 0;
            }
            var Resultado = numero1 / numero2;
            return Resultado;
        }
        public double Multiplicacion(double numero1, double numero2)
        {
            var Resultado = numero1 * numero2;
            return Resultado;
        }

        #endregion


    }
}
