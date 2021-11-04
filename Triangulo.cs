using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGeometry
{
    class Triangulo
    {
        public Triangulo()
        {

        }
        public static Triangulo New()
        {
            return new Triangulo();
        }

        public Double LadoA;
        public Double LadoB;
        public Double LadoC;

        public Double CalcularArea()
        {
            Double p = (this.LadoA + this.LadoB + this.LadoC) / 2.0;
            return Math.Sqrt((p* (p - this.LadoA) * (p - this.LadoB) * (p - this.LadoC)));
        }
    }
}
