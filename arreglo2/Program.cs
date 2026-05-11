int[] notas = new int[15];
int suma = 0;
double promedio = 0;

// Ingreso de notas
for (int i = 0; i < notas.Length; i++)
{
    try
    {
        Console.WriteLine($"Ingrese la nota del estudiante {i + 1}:");
        int nota = int.Parse(Console.ReadLine()!);

        if (nota < 0 || nota > 100)
        {
            throw new ArgumentOutOfRangeException("La nota debe estar entre 0 y 100.");
        }

        notas[i] = nota;
    }
    catch
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: nota inválida, intenta de nuevo");
        Console.ResetColor();
        i--; //repetir la misma posición
    }
}

// Calcular suma
for (int i = 0; i < notas.Length; i++)
{
    suma += notas[i];
}

// Promedio
promedio = (double)suma / notas.Length;

// Ordenar de mayor a menor (para sacar top 3)
Array.Sort(notas);
Array.Reverse(notas);

// Mostrar resultados
Console.WriteLine("Promedio: " + promedio);
Console.WriteLine("Primer lugar: " + notas[0]);
Console.WriteLine("Segundo lugar: " + notas[1]);
Console.WriteLine("Tercer lugar: " + notas[2]);

