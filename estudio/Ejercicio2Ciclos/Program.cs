using System.ComponentModel;
using System.Runtime.CompilerServices;
bool error;
Console.WriteLine("Ingrese un numero positivo para mostrar su tabla de multiplicar hasta 12");
int Numeroposi = 0;
do
{
    error = false;
    try
    {
        
        Numeroposi = int.Parse(Console.ReadLine()!);
        if(Numeroposi >= 0)
        {
    
            Console.WriteLine($"La tabla del: {Numeroposi}");
            int[] tablacompleta = {1,2,3,4,5,6,7,8,9,10,11,12};
            foreach(int numerito in tablacompleta)
            {
            Console.WriteLine($"{Numeroposi} * {numerito} = {Numeroposi * numerito}");
            }
        
        }
        else
        {
            Console.WriteLine("ese numero no es positivo");
            error = true;
        }
    }
    catch (FormatException e)
    {
        Console.WriteLine("error formato no valido, intente de nuevo");
        error = true;
    }

} while (error == true);
