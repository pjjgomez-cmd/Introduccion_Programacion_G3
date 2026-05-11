double[] ventas = new double[7];
string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
double total = 0;
int diasSuperaron = 0;
double ventaMinima;


for (int i = 0; i < 7; i++)
{
    Console.Write("Ingrese las ventas del " + dias[i] + ": $");
    ventas[i] = double.Parse(Console.ReadLine()!);
}

ventaMinima = ventas[0];

for (int i = 0; i < 7; i++)
{
    total += ventas[i];

    if (ventas[i] > 150) diasSuperaron++;
    if (ventas[i] < ventaMinima) ventaMinima = ventas[i];
}

Console.WriteLine("\n--- Resumen de ventas semanales ---");
for (int i = 0; i < 7; i++)
{
    Console.WriteLine(dias[i] + ": $" + ventas[i].ToString("F2"));
}

Console.WriteLine("\nTotal vendido         : $" + total.ToString("F2"));
Console.WriteLine("Días que superaron $150: " + diasSuperaron);
Console.WriteLine("Venta más baja         : $" + ventaMinima.ToString("F2"));
