using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAppPolimorfismo.Ajedrez
{
    public abstract class Pieza
    {
        public virtual string Mover(string movimientos) 
        {
            return $"La pieza se desplaza en {movimientos} cuadros.";
        }   
    }
}
