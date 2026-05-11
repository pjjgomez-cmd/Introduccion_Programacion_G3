int[] numeros = new int[8];
for(int i = 0; i< 8; i++)
{
    Console. WriteLine($"Ingrese el numero {i + 1}");
    numeros[i] = int.Parse(Console.ReadLine());
}
foreach(int numerito in numeros)
{
    if(numerito == 0)
    {
        break;
    }
    else if(numerito <= -1)
    {
        continue;
    }
    else
    {
        Console.WriteLine($"valor {numerito}");
    }
}