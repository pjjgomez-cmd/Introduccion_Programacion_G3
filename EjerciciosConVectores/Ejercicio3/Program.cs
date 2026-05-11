int[] V = { 3, 4, 5, 6, 7 };
double sumaCuadrados = 0;

for (int i = 0; i < V.Length; i++)
{
    sumaCuadrados += V[i] * V[i];
}

double magnitud = Math.Sqrt(sumaCuadrados);

Console.WriteLine("Vector V = (3, 4, 5, 6, 7)");
Console.WriteLine("Suma de cuadrados: " + sumaCuadrados);
Console.WriteLine("Magnitud del vector: " + magnitud);
