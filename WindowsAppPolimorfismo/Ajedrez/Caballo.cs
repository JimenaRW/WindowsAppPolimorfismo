using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAppPolimorfismo.Ajedrez
{
    public class Caballo : Pieza
    {
        public override string Mover(string movimientos)
        {
            return base.Mover(movimientos) + " Se mueve en forma de L.";
        }
    }
}
