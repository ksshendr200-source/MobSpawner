using Variant29_MobSpawner.Models;
namespace Variant29_MobSpawner.Patterns;

/// <summary>Flyweight Factory: по одному объекту общих данных на тип.</summary>
public sealed class MobArchetypeFactory
{
    private readonly Dictionary<string, MobArchetype> _archetypes = new(StringComparer.OrdinalIgnoreCase);
    public MobArchetype GetOrAdd(string key, Func<MobArchetype> create)
    {
        if (_archetypes.TryGetValue(key, out var existing))
        {
            Console.WriteLine($"  [Flyweight] Повторно используются общие данные «{existing.Name}».");
            return existing;
        }
        var archetype = create();
        _archetypes.Add(key, archetype);
        Console.WriteLine($"  [Flyweight] Созданы общие данные типа «{archetype.Name}».");
        return archetype;
    }
    public int Count => _archetypes.Count;
    public IEnumerable<MobArchetype> GetAll() => _archetypes.Values;
}
