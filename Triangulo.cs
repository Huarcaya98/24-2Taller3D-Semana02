using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._2Taller3D_Semana02
{
    internal class Triangulo:Figura
    {

        private float baseTriangulo;
        private float alturaTriangulo;

        public Triangulo(float baseTriangulo, float alturaTriangulo)
        {
            this.baseTriangulo = baseTriangulo;
            this.alturaTriangulo = alturaTriangulo;
        }

        public override float calcArea()
        
        {
            return (baseTriangulo * alturaTriangulo) / 2;
        }
    }
}

