using Variant29_MobSpawner.Models;
namespace Variant29_MobSpawner.Patterns;
public sealed class DragonFactory : MobFactory
{
    public DragonFactory(MobArchetypeFactory sharedTypes) : base(sharedTypes) { }
    protected override string TypeKey => "dragon";
    protected override MobArchetype CreateArchetype() => new("dragon", "Дракон", "dragon.glb", 300, 35, "огромный крылатый дракон", "атакует огнём");
}
