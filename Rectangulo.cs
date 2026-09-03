namespace TallerDiseno3D_S2
{
    internal class Rectangulo : Figura
    {
        float baseRectangulo;
        float altura;
        public Rectangulo(string nombre, float baseRectangulo, float altura)
            : base(nombre)
        {
            this.baseRectangulo = baseRectangulo;
            this.altura = altura;
        }
        public override float Área()
        {
            return baseRectangulo * altura;
        }
    }
}
