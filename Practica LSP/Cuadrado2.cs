

namespace Practica_LSP
{
    public class Cuadrado2 : FiguraGeometrica2
    {
        public double Lado;
        public double Area;
        public override double calcularArea()
        {
            Area = Lado*Lado;
            return Area;
        }
    }
}
