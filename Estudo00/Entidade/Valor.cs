using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo00.Entidade
{
    public class Valor
    {
        public static bool Or(bool left, bool right) => left || right;
        public static bool And(bool left, bool right) => left && right;
        public static bool Xor(bool left, bool right) => left ^ right;
    }
}
