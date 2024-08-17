

namespace Practica_LSP
{
    public class Rectangulo2 : FiguraGeometrica2
    {
        public double Base;
        public double Altura;
        public double Area;
        public override double calcularArea()
        {
            Area = Base * Altura;
            return Area;
        }
    }
}
