// for(int i =0; i<= 5; i++)
// {
//     Console.WriteLine($"Tabla del {i}");
//     int[] numeros10 = {1,2,3,4,5,6,7,8,9,10};
//     foreach(int numerito in numeros10)
//     {
//         Console.WriteLine($"{i} x {numerito} = {i * numerito}");
//     }
// }
using System.ComponentModel;
using System.Reflection.Metadata;

bool error = false;
do
{
    Console.WriteLine("Porfavor ingrese un numero para mostrar su tabla de multiplicacion hasta el 12");
    int Numero = int.Parse(Console.ReadLine()!);

    if (Numero > 0)
    {
        Console.WriteLine($"Esta es la tabla del {Numero}");
        int[] tablas = {1,2,3,4,5,6,7,8,9,10,11,12,};
        foreach(int numerito in tablas)
        {
            Console.WriteLine($"{Numero} * {numerito} = {Numero * numerito}");
        
        }
        error =  false;
    
    }
    else
    {
        Console.WriteLine("Error no se permiten numeros negativos");
        error = true;
    
    }
    
} while (error == true);
    

