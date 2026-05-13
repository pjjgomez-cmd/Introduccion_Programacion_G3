using System.Security.Authentication;

Console.ResetColor();
int[,] matriz = new int[3, 3];
Console.WriteLine("Digite os elementos da matriz 3x3:");
for (int f= 0; f < 3; f++)
{
    for (int c = 0; c < 3; c++)
    {
        Console.Write($"Elemento [{f},{c}]: ");
        matriz[f, c] = int.Parse(Console.ReadLine()!);
    }
}

Console.WriteLine("\nMatriz digitada:");
for (int f = 0; f < 3; f++)
{
    for (int c = 0; c < 3; c++)
    {
        if(matriz[f, c] % 2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        if(matriz[f, c] <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        Console.Write(matriz[f, c] + " ");
    }
    Console.WriteLine();

}
Console.ResetColor();