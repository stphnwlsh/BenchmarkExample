namespace Generators;

public class SharedRandom : IRandom
{
    public int Generate()
    {
        return Random.Shared.Next();
    }
}
