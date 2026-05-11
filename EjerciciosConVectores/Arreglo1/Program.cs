using System.ComponentModel;

int[] edades = new int[10];

// Pedir edades 
for (int i = 0; i < edades.Length; i++)
{
    
    
    try
    {
        Console.WriteLine("Digita la edad " + (i + 1) + ":");
        edades[i] = int.Parse(Console.ReadLine()!);
        
    }
    catch
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Incorrecto, intenta de nuevo");
        Console.ResetColor();
        i--; // clave: retrocede para repetir la misma posición
    }
}

int suma = 0, maximo = edades[0], minimo = edades[0];

// Calcular suma, máximo y mínimo
for (int i = 0; i < edades.Length; i++)
{
    suma += edades[i];

    if (edades[i] > maximo)
        maximo = edades[i];

    if (edades[i] < minimo)
        minimo = edades[i];
}

// Promedio
double promedio = (double)suma / edades.Length;

// Mostrar resultados
Console.WriteLine("Promedio: " + promedio);
Console.WriteLine("Máximo: " + maximo);
Console.WriteLine("Mínimo: " + minimo);


