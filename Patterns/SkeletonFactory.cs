using Variant29_MobSpawner.Models;
namespace Variant29_MobSpawner.Patterns;
public sealed class SkeletonFactory : MobFactory
{
    public SkeletonFactory(MobArchetypeFactory sharedTypes) : base(sharedTypes) { }
    protected override string TypeKey => "skeleton";
    protected override MobArchetype CreateArchetype() => new("skeleton", "Скелет", "skeleton.glb", 60, 12, "скелет с костяным оружием", "держит дистанцию");
}
