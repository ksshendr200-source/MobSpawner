namespace Variant29_MobSpawner.Models;

/// <summary>Экземпляр моба с индивидуальными координатами и здоровьем.</summary>
public sealed class Mob
{
    public int Id { get; }
    public MobArchetype Archetype { get; }
    public int X { get; }
    public int Y { get; }
    public int Health { get; private set; }

    public Mob(int id, MobArchetype archetype, int x, int y)
    {
        if (id <= 0) throw new ArgumentOutOfRangeException(nameof(id));
        Archetype = archetype ?? throw new ArgumentNullException(nameof(archetype));
        Id = id; X = x; Y = y; Health = archetype.BaseHealth;
    }

    public void TakeDamage(int damage)
    {
        if (damage < 0) throw new ArgumentOutOfRangeException(nameof(damage));
        Health = Math.Max(0, Health - damage);
    }

    public string Describe() => $"Моб #{Id}: {Archetype.Name}, позиция=({X}, {Y}), HP={Health}/{Archetype.BaseHealth}, урон={Archetype.BaseDamage}, модель={Archetype.Model}";
}
