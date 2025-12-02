using Estudo03.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo03.Control
{
    public class ControlaValor
    {
        public string VericarParImpar(Valor valor)
        {
            if (valor.Numero % 2 == 0)
            {
                return "Par"; // Par
            }
            else
            {
                return "Impar"; // Ímpar
            }
        }
    }
}
