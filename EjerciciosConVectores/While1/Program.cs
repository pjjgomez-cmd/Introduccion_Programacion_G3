using Math = System.Math;

//Se muestra un numero entero y se muestra todos sus antecesores elevados al cubo 
int numero;

while (true)
{
    Console.WriteLine("Ingrese numero entero");
    if (int.TryParse(Console.ReadLine(), out numero))
    {
        break;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no valida. Porfavor, ingrese un numero entero. ");
        Console.ResetColor();
    }
}

Console.WriteLine(" Los antecesores elevados al cubo son: ");
int contador = 1;
while (contador < numero)
{
    double cubo = Math.Pow(contador, 3);
    Console.WriteLine($"{contador} elevado al cubo = {cubo} ");
    contador++;
}