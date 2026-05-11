int TemperaturaMaxima = int.MinValue;
int[] temperaturas = new int[7];
int Temperaturaminima = int.MaxValue;
int acumuladordePromedio = 0;
bool reinicio = false;
do
{
    Console.WriteLine("Buenos dias, Porfavor ingrese las 7 temperaturas de la semana: ");
    for (int i = 0; i < temperaturas.Length; i++)
    {
        Console.WriteLine($"Ingrese la temperatura del dia {i + 1}:");
        temperaturas[i] = int.Parse(Console.ReadLine()!);
        if (temperaturas[i] > TemperaturaMaxima)
        {
            TemperaturaMaxima = temperaturas[i];
        }
        if (temperaturas[i] < Temperaturaminima)
        {
            Temperaturaminima = temperaturas[i];
        }
    }

    for (int h = 0; h < temperaturas.Length; h++)
    {
        acumuladordePromedio += temperaturas[h];
    }
    
    for (int j = 0; j < temperaturas.Length; j++)
    {
        Console.WriteLine($"La temperatura del dia {j + 1} es: {temperaturas[j]}");
    }
    Console.WriteLine($"El promedio de las temperaturas es: {acumuladordePromedio / 7} ");
    Console.WriteLine($"La temperatura maxima de la semana es: {TemperaturaMaxima}");
    Console.WriteLine($"La temperatura minima de la semana es: {Temperaturaminima}");
    Console.WriteLine("Desea reiniciar el programa? (s/n)");
    string respuesta = Console.ReadLine()!;
    
    if (respuesta == "s")
    {
        reinicio = true;
    }
} while (reinicio == true);


