using System;
using Microsoft.Xna.Framework;
using DefaultEcs;
using DefaultEcs.System;
using ShootyShapes.Components;

namespace ShootyShapes.Systems
{
    [With(typeof(Position))]
    [With(typeof(Velocity))]
    public class VelocitySystem : AEntitySystem<float>
    {
        public VelocitySystem(World world, SystemRunner<float> runner) : base(world, runner)
        {
        }

        protected override void Update(float deltaTime, in Entity entity)
        {
            ref Position position = ref entity.Get<Position>();
            ref Velocity velocity = ref entity.Get<Velocity>();

            position.Value += velocity.Value * deltaTime;
        }
    }
}
