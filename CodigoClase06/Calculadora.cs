using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase06
{
   struct  Calculadora
    {
        public int a;
        public int b;
        public int Sumar()
        {
            return a + b;
        }
        public int Restar()
        {
            return a - b;
        }
        public int Multiplicar()
        {
            return a * b;
        }
        public int Dividir()
        {
            return a / b;
        }
    }
}
