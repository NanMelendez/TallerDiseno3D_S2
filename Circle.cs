using System;
using System.Collections.Generic;
using System.Text;

namespace TallerDiseno3D_S2
{
    internal class Circle : Figura
    {
        float radio;
        float area;
        public Circle(string nombre, float radio) : base(nombre)
        {
            this.radio = radio;
        }
        public override float Área()
        {
            area = 3.14f * radio * radio;
            return area;
        }
    }
}
