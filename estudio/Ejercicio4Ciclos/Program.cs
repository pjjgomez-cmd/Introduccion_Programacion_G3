for(int i = 0; i <= 20; i++)
{
    if( i == 15)
    {
        break;
    }
    else if ((i % 3) ==0)
    {
        continue;
    }
    else
    {
        Console.WriteLine($"valor {i}");
    }
}