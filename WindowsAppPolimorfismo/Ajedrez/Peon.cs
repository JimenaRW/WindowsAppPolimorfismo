using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAppPolimorfismo.Ajedrez
{
    public class Peon : Pieza
    {
        public override string Mover(string movimientos)
        {
            return base.Mover(movimientos) + " Avanza hacia adelante.";
        }
    }
}
