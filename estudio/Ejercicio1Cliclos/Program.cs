Console.WriteLine("Bienvenido al programa de las Tablas del 1 al 5, con las multiplicaciones del 1 al 10");
string continuacion = "";
do
{
  Console.Write("Para continuar escribe s/n:");
  continuacion = Console.ReadLine()!;
  
  if(continuacion == "s")
    {
        for(int i = 1; i<= 5; i ++)
        {
            Console.WriteLine($"Tabla del {i}");
            int[] numeros = {1,2,3,4,5,6,7,8,9,10};
        foreach(int multuplicaciones in numeros)
        {
            Console.WriteLine($"{multuplicaciones} x {i} = {multuplicaciones * i}");
        }
        }

        
    }
 
} while (continuacion == "");
