using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using DefaultEcs;
using DefaultEcs.System;
using ShootyShapes.Components;

namespace ShootyShapes.Systems
{
    [With(typeof(Rotation))]
    [With(typeof(Velocity))]
    [With(typeof(Player))]
    public class PlayerControlSystem : AEntitySystem<float>
    {
        KeyboardState _keyboardState;
        GamePadState _gamepadState;
        MouseState _mouseState;

        public PlayerControlSystem(World world) : base(world)
        {

        }

        public void UpdateInputState(KeyboardState kb, GamePadState gamepad, MouseState mouse)
        {
            _keyboardState = kb;
            _gamepadState = gamepad;
            _mouseState = mouse;
        }

        protected override void Update(float deltaTime, in Entity entity)
        {
            ref Rotation rot = ref entity.Get<Rotation>();
            ref Velocity velocity = ref entity.Get<Velocity>();
            ref Player player = ref entity.Get<Player>();


        }
    }
}
