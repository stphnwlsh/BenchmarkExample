namespace Generators;

public class LockedRandom
{
    private readonly Random randomizer = new(Guid.NewGuid().GetHashCode());

    public int Next()
    {
        lock (this.randomizer)
        {
            return this.randomizer.Next();
        }
    }
}
