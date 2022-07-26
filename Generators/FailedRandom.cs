namespace Generators;

public class FailedRandom
{
    private readonly Random randomizer = new();

    public int Next()
    {
        return this.randomizer.Next();
    }
}
