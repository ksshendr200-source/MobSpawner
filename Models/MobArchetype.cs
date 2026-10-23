namespace Variant29_MobSpawner.Models;

/// <summary>Общие неизменяемые данные типа моба (Flyweight).</summary>
public sealed class MobArchetype
{
    public string Key { get; }
    public string Name { get; }
    public string Model { get; }
    public int BaseHealth { get; }
    public int BaseDamage { get; }
    public string Appearance { get; }
    public string Behavior { get; }

    public MobArchetype(string key, string name, string model, int baseHealth, int baseDamage, string appearance, string behavior)
    {
        if (string.IsNullOrWhiteSpace(key)) throw new ArgumentException("Ключ типа обязателен.", nameof(key));
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Название типа обязательно.", nameof(name));
        if (string.IsNullOrWhiteSpace(model)) throw new ArgumentException("Модель обязательна.", nameof(model));
        if (baseHealth <= 0) throw new ArgumentOutOfRangeException(nameof(baseHealth));
        if (baseDamage <= 0) throw new ArgumentOutOfRangeException(nameof(baseDamage));
        Key = key; Name = name; Model = model; BaseHealth = baseHealth; BaseDamage = baseDamage;
        Appearance = appearance; Behavior = behavior;
    }

    public override string ToString() => $"{Name}: модель={Model}, базовое HP={BaseHealth}, урон={BaseDamage}, внешность={Appearance}, поведение={Behavior}";
}
