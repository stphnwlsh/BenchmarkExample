namespace Generators;

public class FailedRandom : IRandom
{
    private readonly Random randomizer = new();

    public int Generate()
    {
        return this.randomizer.Next();
    }
}
