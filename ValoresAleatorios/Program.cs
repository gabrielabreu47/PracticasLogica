Main();

void Main()
{
    var elementCount = 5;
    Console.WriteLine("Ingrese la cantidad de numeros random que desea generar");
    try
    {
        elementCount = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Debe de ingresar un numero valido");
        Main();
    }
    
    if (elementCount > 20)
    {
        Console.WriteLine("Debe de ingresar un numero menor que 20");
        Main();
    }
    else if (elementCount < 1)
    {
        Console.WriteLine("Debe de ingresar un numero mayor que 0");
        Main();
    }
    
    var randomNumbers = new List<int>();

    for (int i = 1; i <= elementCount; i++)
    {
        var random = new Random();
        int randomNumber = random.Next(1,100);
        while (randomNumbers.Contains(randomNumber))
        {
            randomNumber = random.Next(1,100);
        }
        randomNumbers.Add(randomNumber);
    }

    var result = string.Join(", ", randomNumbers);
    Console.WriteLine(result);
    Console.Read();
}