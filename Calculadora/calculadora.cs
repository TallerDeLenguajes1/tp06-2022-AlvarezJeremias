using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class calcu
    {
        private double primerNumero;
        private double segundoNumero;

        public double firstNumber { 
            get => primerNumero; 
            set => primerNumero=value; }

        public double secondNumber
        {
            get => segundoNumero;
            set => segundoNumero = value;
        }

        public double suma ()
        {
            return firstNumber+secondNumber;
        }
        public double resta()
        {
            return firstNumber - secondNumber;
        }
        public double producto ()
        {
            return firstNumber * secondNumber;
        }
        public double division ()
        {
            if (secondNumber != 0)
            {
                return firstNumber/ secondNumber;
            }else
            {
                return 0;
            }
        }
        public int Limpiar ()
        {
            return 0;
        }
    }
}
