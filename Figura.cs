using System;
using System.Collections.Generic;
using System.Text;

namespace TallerDiseno3D_S2
{
    internal class Figura
    {
        public string nombre;

        public Figura(string nombre)
        {
            this.nombre = nombre;
        }

        public virtual float Área()
        {
            return 0.0f;
        }
    }
}
