
int[] A = new int[5];
int[] B = new int[5];
int[] resultado = new int[5];

        
int[] valoresA = { 15, 18, 20, 25, 30 };
int[] valoresB = { 5, 8, 10, 12, 15 };

for (int i = 0; i < 5; i++)
{
    A[i] = valoresA[i];
    B[i] = valoresB[i];
}

        
for (int i = 0; i < 5; i++)
{
    resultado[i] = A[i] - B[i];
}

        
Console.WriteLine("Vector resultante (A - B):");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Posición {i}: {resultado[i]}");
}