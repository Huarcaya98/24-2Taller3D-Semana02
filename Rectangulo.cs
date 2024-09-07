using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._2Taller3D_Semana02
{
    internal class Rectangulo:Figura
    {
        private float baseRectangulo;
        private float alturaRectangulo;

        public Rectangulo(float baseRectangulo, float alturaRectangulo)
        {
            this.baseRectangulo = baseRectangulo;
            this.alturaRectangulo = alturaRectangulo;
        }

        public override float calcArea()
        
        {
            return baseRectangulo * alturaRectangulo;
        }

        public override float calcPerimetro()
        {
            return 2 * (baseRectangulo + alturaRectangulo);
        }

    }
}
