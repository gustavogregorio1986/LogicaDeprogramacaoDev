using Estudo3.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo3.Control
{
    public class ControlaValor
    {
        public int DobroDoValor(Valor valor)
        {
            return valor.Numero * 2;
        }
    }
}
