namespace Generators;

public class SharedRandom
{
    public int Next()
    {
        return Random.Shared.Next();
    }
}
