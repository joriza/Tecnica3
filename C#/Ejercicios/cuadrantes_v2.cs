using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar ingreso de coordenadas
        Console.Write("Ingresa la coordenada X: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa la coordenada Y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        // Determinar el cuadrante o la ubicación
        string resultado = (x == 0 && y == 0) ? "en el origen" :
                           (x == 0) ? "sobre el eje Y" :
                           (y == 0) ? "sobre el eje X" :
                           (x > 0 && y > 0) ? "en el Primer Cuadrante" :
                           (x < 0 && y > 0) ? "en el Segundo Cuadrante" :
                           (x < 0 && y < 0) ? "en el Tercer Cuadrante" :
                                              "en el Cuarto Cuadrante";

        Console.WriteLine($"La coordenada ({x}, {y}) está {resultado}.");
    }
}

/*
Optimización:

    Se utiliza un solo Console.WriteLine con interpolación de cadenas para mostrar el resultado.
    Las condiciones se agrupan usando el operador ternario ? : para simplificar la estructura y reducir la cantidad de líneas.
    El código sigue siendo legible pero más compacto y eficiente.
*/