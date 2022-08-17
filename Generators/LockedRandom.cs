namespace Generators;

public class LockedRandom : IRandom
{
    public string Name => "LockedRandom";

    private readonly Random randomizer = new(Guid.NewGuid().GetHashCode());

    public int Generate()
    {
        lock (this.randomizer)
        {
            return this.randomizer.Next(1, int.MaxValue);

        }
    }
}
