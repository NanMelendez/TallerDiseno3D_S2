namespace TallerDiseno3D_S2
{
    internal class Triangulo : Figura
    {
        float baseTriangulo;
        float altura;
        public triangulo(float baseTriangulo, float altura)
        {
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
        }
        public override float AreaTraingulo()
        {
            return (baseTriangulo * altura) / 2;
        }
    }
}
