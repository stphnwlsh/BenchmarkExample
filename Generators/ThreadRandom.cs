namespace Generators;

public class ThreadRandom : IRandom
{
    private readonly ThreadLocal<Random> randomizer = new(() =>
        new Random(Guid.NewGuid().GetHashCode()));

    public int Generate()
    {
        return this.randomizer.Value.Next();
    }
}
