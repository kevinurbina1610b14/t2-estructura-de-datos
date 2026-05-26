using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    internal class nodop
    {
        public empleado Valor;
        public nodop Izqu;
        public nodop Dere;

        public nodop(empleado valor)
        {
            Valor = valor;
            Izqu = null;
            Dere = null;
        }
    }
}
