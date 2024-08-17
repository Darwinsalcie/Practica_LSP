using System;

// Clase base FiguraGeometrica
public class FiguraGeometrica1
{
    public double Base { get; set; }
    public double Altura { get; set; }
}

// Clase derivada Rectangulo
public class Rectangulo1 : FiguraGeometrica1
{
    public double CalcularArea()
    {
        return Base * Altura;
    }
}

// Clase derivada Cuadrado
public class Cuadrado1 : FiguraGeometrica1
{
    // Método que no cumple correctamente el cálculo para un cuadrado
    public double CalcularArea()
    {
        // Devolvemos el área de un rectángulo en lugar de un cuadrado
        return Base * Altura;
    }
}
