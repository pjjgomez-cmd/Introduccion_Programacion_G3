int[] puntajes = new int[6];
int maximo = 0;
int mayores500 = 0;

// Ingresar los 6 puntajes
for (int i = 0; i < 6; i++)
{
    Console.Write("Ingrese el puntaje de la partida " + (i + 1) + ": ");
    puntajes[i] = int.Parse(Console.ReadLine());
}

// Puntaje más alto y contar mayores a 500
for (int i = 0; i < 6; i++)
{
    if (puntajes[i] > maximo) maximo = puntajes[i];
    if (puntajes[i] > 500) mayores500++;
}

// Ordenar de menor a mayor (burbuja)
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5 - i; j++)
    {
        if (puntajes[j] > puntajes[j + 1])
        {
            int temp    = puntajes[j];
            puntajes[j] = puntajes[j + 1];
            puntajes[j + 1] = temp;
        }
    }
}

// Mostrar resultados
Console.WriteLine("\nPuntaje más alto: " + maximo);
Console.WriteLine("Puntajes mayores a 500: " + mayores500);
Console.WriteLine("\nPuntajes ordenados:");
for (int i = 0; i < 6; i++)
{
    Console.WriteLine("  " + (i + 1) + ": " + puntajes[i]);
}