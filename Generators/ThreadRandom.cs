namespace Generators;

public class ThreadRandom
{
    private readonly ThreadLocal<Random> randomizer = new(() =>
        new Random(Guid.NewGuid().GetHashCode()));

    public int Next()
    {
        return this.randomizer.Value.Next();
    }
}
