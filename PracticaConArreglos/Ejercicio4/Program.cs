int[] ventas = new int[5];
string[] categorias = { "Ficción", "Ciencia", "Historia", "Infantil", "Tecnología" };
int total = 0;
int indiceMayor = 0;

// Ingresar ventas por categoría
for (int i = 0; i < 5; i++)
{
    Console.Write("Ventas de " + categorias[i] + ": ");
    ventas[i] = int.Parse(Console.ReadLine()!);
}

// Calcular total y categoría con más ventas
for (int i = 0; i < 5; i++)
{
    total += ventas[i];
    if (ventas[i] > ventas[indiceMayor]) indiceMayor = i;
}

double promedio = total / 5.0;

// Mostrar resultados
Console.WriteLine("\nTotal de libros vendidos : " + total);
Console.WriteLine("Categoría con más ventas : " + categorias[indiceMayor] + " (" + ventas[indiceMayor] + " libros)");
Console.WriteLine("Promedio de ventas       : " + promedio.ToString("F2"));