namespace Generators;

public class FailedRandom : IRandom
{
    public string Name => "FailedRandom";

    private readonly Random randomizer = new();

    public int Generate()
    {
        return this.randomizer.Next();
    }
}
