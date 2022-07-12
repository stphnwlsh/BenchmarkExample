Console.WriteLine("Started Running");

var list = new List<long>();

for (var x = 0; x < 10000; x++)
{
    var number = Random.Shared.Next(int.MinValue, int.MaxValue);
    list.Add(number);
    Console.WriteLine(number);
}

Console.WriteLine($"List has {list.Count} items");

Console.WriteLine("Finished Running");
