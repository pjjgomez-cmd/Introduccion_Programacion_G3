using System.Collections.Specialized;
using System.Numerics;

Console.WriteLine("Bienvenido a la empresa de logistica de Drones");
Console.WriteLine("Las pociciones asignadas de dos vectores asignados son:");
Console.WriteLine("Vector A = (2,4,6,8,10) y vector B = (1,3,5,6,7,9)");

int[] vectorA = {2,4,6,8,10};
int[] vectorB = [1,3,5,7,9];
int[] vectorresultado = new int[5];

for(int i=0; i<= vectorresultado.Length; i++)
{
    vectorresultado[i] = vectorA[i] + vectorB[i];
    Console.WriteLine($"{vectorresultado[i]}");
}
