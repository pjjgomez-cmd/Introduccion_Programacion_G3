using System.ComponentModel;

Console.WriteLine("Bienvenido al generador de triangulos y cuadrados");
bool error = false;
do
{
    Console.WriteLine("Porfavor ingrese <c> para cuadrado y <t> para triangulo");
    string opcion = Console.ReadLine()!;
    if(opcion == "c")
    {
        bool errorc = false;
        do
        {    
            try
            {
                Console.WriteLine("introdusca el largo del lado :");
                int numerodelado = int.Parse(Console.ReadLine()!);
                
                if(numerodelado > 1)
                {
                    
                    for(int i = 1; i<= numerodelado; i++)
                    {
                        for(int j = 1; j<= numerodelado; j++)
                        {
                            Console.Write("[]");
                        }
                        Console.WriteLine();
                    }
                    errorc = false;
                    error = false;
                }
                else
                {
                    Console.WriteLine("Error numero de lineas no valido intente de nuevo");
                    errorc = true;
                }
                    
            }
            catch(Exception e)
            {
                Console.WriteLine("error intente de nuevo");
                errorc = true;
            }
        }
        while(errorc == true);       
    }
    else if(opcion == "t")
    {
        Console.WriteLine("introdusca la altura del triangulo");
        int altura = int.Parse(Console.ReadLine()!);
        for(int h = 1; h<= altura; h++)
        {
            for(int g = 1; g<= altura - h; g++)
            {
                Console.Write(" ");
            }
            for(int f = 1; f<= (2 * h - 1); f++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
        error = false;

    }
    else
    {
        Console.WriteLine("Error ingresa una opcion valida");
        error = true;

    }  
    
} while(error == true);
