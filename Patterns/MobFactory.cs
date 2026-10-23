using Variant29_MobSpawner.Models;
namespace Variant29_MobSpawner.Patterns;

/// <summary>Factory Method: общий алгоритм создания моба.</summary>
public abstract class MobFactory
{
    private readonly MobArchetypeFactory _sharedTypes;
    protected MobFactory(MobArchetypeFactory sharedTypes) => _sharedTypes = sharedTypes ?? throw new ArgumentNullException(nameof(sharedTypes));
    protected abstract string TypeKey { get; }
    protected abstract MobArchetype CreateArchetype();
    public Mob Create(int id, int x, int y)
    {
        var archetype = _sharedTypes.GetOrAdd(TypeKey, CreateArchetype);
        return new Mob(id, archetype, x, y);
    }
}
