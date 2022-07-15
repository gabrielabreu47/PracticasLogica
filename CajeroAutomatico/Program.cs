var Bills = new List<int>
{
    2000,
    1000,
    500,
    200,
    100,
    50
};

Console.WriteLine("Ingrese la cantidad de dinero");
var amount = Convert.ToInt32(Console.ReadLine());

var billResults = new Dictionary<int, int>();

foreach (var bill in Bills)
{
    var currentBillCount = GetBillCount(ref amount, bill);
    if (currentBillCount > 0)
    {
        billResults.Add(bill, currentBillCount);
    }
}

foreach (var billResult in billResults)
{
    Console.WriteLine($"{billResult.Value} billete/s de {billResult.Key}");
}

Console.Read();

int GetBillCount(ref int amount, int bill)
{
    var billCountAproximate = amount / bill;
    if (billCountAproximate < 1) return 0;
    var reduce  = amount - (bill * (billCountAproximate - 1));
    var billCount = (reduce < bill) ? billCountAproximate - 1 : billCountAproximate;
    amount -= (bill * billCount);
    return billCount;
}