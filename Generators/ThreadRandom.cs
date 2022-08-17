namespace Generators;

public class ThreadRandom : IRandom
{
    public string Name => "ThreadRandom";

    private readonly ThreadLocal<Random> randomizer = new(() =>
        new Random(Guid.NewGuid().GetHashCode()));

    public int Generate()
    {
        return this.randomizer.Value.Next(1, int.MaxValue);
    }
}
