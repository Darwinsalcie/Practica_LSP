


using Practica_LSP;

Rectangulo1 rectangulo = new Rectangulo1 { Base = 3, Altura = 4 };
Cuadrado1 cuadrado = new Cuadrado1 { Base = 3, Altura = 4 };        //No deberían estar estos campos en cuadrado, ni ser admisibles

Console.WriteLine($"Área del rectángulo: {rectangulo.CalcularArea()}"); // Salida correcta: 12
Console.WriteLine($"Área del cuadrado: {cuadrado.CalcularArea()}");     // Salida incorrecta para un cuadrado: 12
 

Console.WriteLine("\n\n\n\n**************Ejecutando el programa Refactorizado*************\n\n\n\n");

Rectangulo2 rectangulo2 = new Rectangulo2 { Base = 3, Altura=4 };
Cuadrado2 cuadrado2 = new Cuadrado2 { Lado=3 };


Console.WriteLine($"\nÁrea del rectángulo: {rectangulo2.calcularArea()}\n"); // Salida correcta: 12
Console.WriteLine($"\nÁrea del cuadrado: {cuadrado2.calcularArea()}\n");     // Salida incorrecta para un cuadrado: 12

