double[] notas = new double[8];
double total = 0;
int reprobados = 0;

// Ingresar notas
for (int i = 0; i < 8; i++)
{
    Console.Write("Nota del estudiante " + (i + 1) + ": ");
    notas[i] = double.Parse(Console.ReadLine()!);
}

// Calcular total, reprobados
for (int i = 0; i < 8; i++)
{
    total += notas[i];
    if (notas[i] < 60) reprobados++;
}

double promedio = total / 8;

// Mostrar notas aprobadas
Console.WriteLine("\nNotas aprobadas:");
for (int i = 0; i < 8; i++)
{
    if (notas[i] >= 60)
        Console.WriteLine("  Estudiante " + (i + 1) + ": " + notas[i]);
}

// Mostrar resultados
Console.WriteLine("\nEstudiantes reprobados : " + reprobados);
Console.WriteLine("Promedio general       : " + promedio.ToString("F2"));
