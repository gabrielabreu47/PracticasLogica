Main();

void Main()
{
    int cousinPrime = 9;

    Console.WriteLine("Ingrese la cantidad de numeros primos que desea visualizar");

    try
    {
        cousinPrime = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Debe de ingresar un numero valido");
        Main();
    }
    
    Console.WriteLine("Resultado:");
    
    for (int i = 2; i <= cousinPrime + 1; i++)
    {
        if (IsCousinPrime(i))
        {
            Console.WriteLine(i);
        }
    }

    Console.Read();
}


bool IsCousinPrime(int number)
{
    for (int index = 2; index < number; index++)
    {
        if(number % index == 0)
        {
            return false;
        }
    }
    return true;
}
