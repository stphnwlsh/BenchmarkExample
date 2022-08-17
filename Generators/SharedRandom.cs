namespace Generators;

public class SharedRandom : IRandom
{
    public string Name => "SharedRandom";

    public int Generate()
    {
        return Random.Shared.Next();
    }
}
