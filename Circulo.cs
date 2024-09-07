using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._2Taller3D_Semana02
{
    internal class Circulo:Figura
    {
        private float radio;

        public Circulo(float radio)
        {
            this.radio = radio;
        }

        public override float calcArea()
       
        {
            return (float)(Math.PI * Math.Pow(radio, 2));
        }


    }
}
