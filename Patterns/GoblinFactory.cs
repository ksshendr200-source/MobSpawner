using Variant29_MobSpawner.Models;
namespace Variant29_MobSpawner.Patterns;
public sealed class GoblinFactory : MobFactory
{
    public GoblinFactory(MobArchetypeFactory sharedTypes) : base(sharedTypes) { }
    protected override string TypeKey => "goblin";
    protected override MobArchetype CreateArchetype() => new("goblin", "Гоблин", "goblin.glb", 45, 8, "маленький зелёный гуманоид", "атакует группой");
}
