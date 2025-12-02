using Estudo4.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo4.Control
{
    public class ControlaValor
    {
        public int Antecessor(Valor valor)
        {
            int antecessor = valor.Numero - 1;
            return antecessor;
        }

        public int Sucessor(Valor valor)
        {
            int antecessor = valor.Numero + 1;
            return antecessor;
        }
    }
}
