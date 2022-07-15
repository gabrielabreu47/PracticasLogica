Main();

void Main()
{
    var randomNumbers = GetRandomNumbers();

    var cousinPrimeNumbers = GetCousinPrimeNumbers();

    var coincidences = randomNumbers.Intersect(cousinPrimeNumbers);
    
    int biggestNumber = 0;
    
    foreach (var number in coincidences)
    {
        biggestNumber = number > biggestNumber ? number : biggestNumber;
    }

    Console.WriteLine($"Coincidencia: {biggestNumber}");
    
    Console.WriteLine($"Fibonacci con {biggestNumber} elementos");
    
    PrintFibonacci(biggestNumber);

    Console.Read();
}

List<int> GetRandomNumbers()
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
    return randomNumbers;
}

List<int> GetCousinPrimeNumbers()
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

    var cousinPrimeNumbers = new List<int>();

    for (int i = 2; i <= cousinPrime + 1; i++)
    {
        if (IsCousinPrime(i))
        {
            cousinPrimeNumbers.Add(i);
            Console.WriteLine(i);
        }
    }

    return cousinPrimeNumbers;
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

void PrintFibonacci(int len)  
{  
    int a = 0, b = 1, c = 0;  
    Console.Write($"{a} {b}");  
    for (int i = 2; i < len; i++)  
    {  
        c = a + b;  
        Console.Write($" {c}");  
        a = b;  
        b = c;  
    }  
}  
