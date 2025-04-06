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

        // Determinar el cuadrante
        if (x > 0 && y > 0)
        {
            Console.WriteLine("La coordenada ({0}, {1}) está en el Primer Cuadrante.", x, y);
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("La coordenada ({0}, {1}) está en el Segundo Cuadrante.", x, y);
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("La coordenada ({0}, {1}) está en el Tercer Cuadrante.", x, y);
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("La coordenada ({0}, {1}) está en el Cuarto Cuadrante.", x, y);
        }
        else if (x == 0 && y != 0)
        {
            Console.WriteLine("La coordenada ({0}, {1}) está sobre el eje Y.", x, y);
        }
        else if (x != 0 && y == 0)
        {
            Console.WriteLine("La coordenada ({0}, {1}) está sobre el eje X.", x, y);
        }
        else
        {
            Console.WriteLine("La coordenada ({0}, {1}) está en el origen.", x, y);
        }
    }
}

/*
Explicación:

    Se solicita al usuario ingresar las coordenadas x e y.
    Luego, se utilizan condicionales if para determinar en qué cuadrante del plano cartesiano se encuentra la coordenada ingresada:
        Primer cuadrante: x > 0 y y > 0.
        Segundo cuadrante: x < 0 y y > 0.
        Tercer cuadrante: x < 0 y y < 0.
        Cuarto cuadrante: x > 0 y y < 0.
        Si x = 0, la coordenada está sobre el eje Y.
        Si y = 0, la coordenada está sobre el eje X.
        Si ambos son 0, la coordenada está en el origen.
*/