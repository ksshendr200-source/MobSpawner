using Variant29_MobSpawner.Models;
namespace Variant29_MobSpawner.Patterns;
public sealed class MobSpawner
{
    private readonly List<Mob> _spawned = new();
    private int _nextId = 1;
    public IReadOnlyList<Mob> Spawned => _spawned;
    public Mob Spawn(MobFactory factory, int x, int y)
    {
        ArgumentNullException.ThrowIfNull(factory);
        var mob = factory.Create(_nextId++, x, y);
        _spawned.Add(mob);
        Console.WriteLine($"  [Спавнер] Появился {mob.Archetype.Name} #{mob.Id} в точке ({x}, {y}).");
        return mob;
    }
    public void PrintWave()
    {
        Console.WriteLine("\nСостав волны:");
        foreach (var mob in _spawned) Console.WriteLine("  " + mob.Describe());
    }
}
